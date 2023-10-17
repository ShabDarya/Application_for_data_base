using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Kurs
{
    public class bd
    {
        public static bool fromTK = false;
        public enum users: int
        {
            glava =1,
            technolog = 3,
            klad = 5,
            mened = 4
        }

        public static MySqlConnection Connection;

        public static void SqlConnect()
        {
            string connect = "SERVER = localhost;Database=kyrsovaya;UID=root; Password=1234; convert zero datetime=True; ";
            Connection = new MySqlConnection(connect);
        }

        public static void DeleteKurs(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);

            command.CommandText = "SELECT * FROM поступление WHERE `Код поступления`=@VALUE";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int count = (int)reader["Количество"]; 
                int np = (int)reader["Код НП"];
                int skl = (int)reader["Код склада"];               
                reader.Close();

                List<int> z = new List<int> { np, count, skl };
                Connection.Close();
                MinusZapas(z);
            }

            Connection.Open();
            command.CommandText = "DELETE FROM kyrsovaya.поступление WHERE `Код поступления` = @VALUE;";
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public static void AddKurs(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            for(int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    Connection.Close();
                    return;
                }
            }
            command.Parameters.AddWithValue("@np", Int32.Parse(q[0]));
            command.Parameters.AddWithValue("@col", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@skl", Int32.Parse(q[2]));
            command.CommandText = "INSERT INTO поступление (`Код НП`, Количество, `Код склада`)  VALUES (@np, @col, @skl);";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
            }
            catch(Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
            List<int> z = new List<int>();
            for(int i = 0; i < q.Count; i++)
            {
                z.Add(Int32.Parse(q[i]));
            }
            Connection.Close();
            PlusZapas(z);
        }
        public static void EditKurs(List<string> q, List<int> zap)
        {
            MinusZapasK(zap);
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    return;
                }
            }
            command.Parameters.AddWithValue("@id", Int32.Parse(q[0]));
            command.Parameters.AddWithValue("@np", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@col", Int32.Parse(q[2]));
            command.Parameters.AddWithValue("@skl", Int32.Parse(q[3]));
            command.CommandText = "UPDATE поступление SET `Код НП` = @np,    Количество = @col,    `Код склада` = @skl WHERE `Код поступления` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
                Connection.Close();
                PlusZapas(zap);
                return;
            }
            List<int> z = new List<int>();
            for (int i = 0; i < q.Count; i++)
            {
                z.Add(Int32.Parse(q[i]));
            }
            z.RemoveAt(0);
            Connection.Close();
            PlusZapas(z);
        }

        public static void PlusZapas(List<int> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            MySqlCommand command1 = Connection.CreateCommand();
            command.Parameters.AddWithValue("@np", q[0]);
            command.Parameters.AddWithValue("@skl", q[2]);
            command1.Parameters.AddWithValue("@np", q[0]);
            command1.Parameters.AddWithValue("@skl", q[2]);
            command.CommandText = "SELECT * FROM запас WHERE `Код НП`=@np AND `Код склада`=@skl";
            MySqlDataReader reader = command.ExecuteReader();
            bool be = true;
            if (reader.Read())
            {
                
                be = false;
                int count = (int)reader["Кол-во"];
                count += q[1];
                reader.Close();
                command1.Parameters.AddWithValue("@c", count);
                command1.CommandText = "UPDATE запас  SET `Кол-во` = @c, `Код склада` = @skl, `Код НП` = @np WHERE `Код склада` = @skl AND `Код НП` = @np; ";
                command1.ExecuteNonQuery();
            }
            reader.Close();
            if (be)
            {
                command1.Parameters.AddWithValue("@c", q[1]);
                command1.CommandText = "INSERT INTO запас (`Кол-во`, `Код склада`, `Код НП`)  VALUES(@c, @skl, @np); ";
                command1.ExecuteNonQuery();
            }
            Connection.Close();
        }
        public static bool MinusZapas(List<int> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            MySqlCommand command1 = Connection.CreateCommand();
            command.Parameters.AddWithValue("@np", q[0]);
            command.Parameters.AddWithValue("@skl", q[2]);
            command1.Parameters.AddWithValue("@np", q[0]);
            command1.Parameters.AddWithValue("@skl", q[2]);
            command.CommandText = "SELECT * FROM запас WHERE `Код НП`=@np AND `Код склада`=@skl";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int count = (int)reader["Кол-во"];
                count -= q[1];
                reader.Close();
                if (count == 0)
                {
                    command1.CommandText = "DELETE FROM запас WHERE `Код склада`=@skl AND `Код НП`= @np;";
                    command1.ExecuteNonQuery();
                    Connection.Close();
                    return true;
                }
                else if(count < 0)
                {
                    Connection.Close();
                    return false;
                }
                else
                {
                    command1.Parameters.AddWithValue("@c", count);
                    command1.CommandText = "UPDATE запас  SET `Кол-во` = @c, `Код склада` = @skl, `Код НП` = @np WHERE `Код склада` = @skl AND `Код НП` = @np; ";
                    command1.ExecuteNonQuery();
                }
                Connection.Close();
                return true;
            }

            Connection.Close();
            return false;
        }
        public static bool MinusZapasK(List<int> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            MySqlCommand command1 = Connection.CreateCommand();
            command.Parameters.AddWithValue("@np", q[0]);
            command.Parameters.AddWithValue("@skl", q[2]);
            command1.Parameters.AddWithValue("@np", q[0]);
            command1.Parameters.AddWithValue("@skl", q[2]);
            command.CommandText = "SELECT * FROM запас WHERE `Код НП`=@np AND `Код склада`=@skl";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int count = (int)reader["Кол-во"];
                count -= q[1];
                reader.Close();
                if (count <= 0)
                {
                    command1.CommandText = "DELETE FROM запас WHERE `Код склада`=@skl AND `Код НП`= @np;";
                    command1.ExecuteNonQuery();
                    Connection.Close();
                    return true;
                }
                else
                {
                    command1.Parameters.AddWithValue("@c", count);
                    command1.CommandText = "UPDATE запас  SET `Кол-во` = @c, `Код склада` = @skl, `Код НП` = @np WHERE `Код склада` = @skl AND `Код НП` = @np; ";
                    command1.ExecuteNonQuery();
                }
                Connection.Close();
                return true;
            }

            Connection.Close();
            return false;
        }

        public static bool SpisanieZapas(List<List<int>> q, int pz, int tk, int no)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT * FROM запас";
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            reader.Close();
            int c = 0;
            for (int i = 0; i < q.Count; i++)
            {
                command.Parameters.AddWithValue("@np", q[i][0]);
                command.Parameters.AddWithValue("@col", q[i][1]);
                command.CommandText = "SELECT * FROM запас  WHERE `Код НП`=@np  GROUP BY `Код НП`";
                reader = command.ExecuteReader();
                reader.Read();
                c = Int32.Parse(reader["Кол-во"].ToString());
                if (c < q[i][1]) return false;
                command.Parameters.Clear();
                reader.Close();
            }
            for (int i = 0; i < q.Count; i++)
            {
                command.Parameters.AddWithValue("@np", q[i][0]);
                command.CommandText = "SELECT * FROM запас WHERE `Код НП`=@np";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<int> a = new List<int>();
                    a.Add(q[i][0]);
                   
                    if (q[i][1] <= Int32.Parse(reader["Кол-во"].ToString()))
                    {
                        a.Add(q[i][1]);
                        a.Add(Int32.Parse(reader["Код склада"].ToString()));
                        reader.Close();
                        Connection.Close();
                        MinusZapas(a);
                        AddJurn(a, pz, tk, no);
                        Connection.Open();
                        break;
                    }
                    else
                    {
                        a.Add(Int32.Parse(reader["Кол-во"].ToString()));
                        a.Add(Int32.Parse(reader["Код склада"].ToString()));
                        Connection.Close();
                        MinusZapas(a);
                        AddJurn(a, pz, tk, no);
                        Connection.Open();
                    }
                }
                command.Parameters.Clear();
                reader.Close();
            }
            reader.Close();
            Connection.Close();
            return true;
        }
        public static bool DobavlZapas(List<List<int>> q, int pz)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT * FROM склад";
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int skl = Int32.Parse(reader["Код склада"].ToString());
            reader.Close();
            for (int i = 0; i < q.Count; i++)
            {
                List<int> w = new List<int> { q[i][1], q[i][2], skl };
                Connection.Close();
                PlusZapas(w);
                Connection.Open();
                command.Parameters.AddWithValue("@id", q[i][0]);
                command.CommandText = "DELETE FROM `журнал потребления` WHERE `Код потребления`=@id";
                reader = command.ExecuteReader();                
                command.Parameters.Clear();
            }
            Connection.Close();
            return true;
        }

        public static void DeleteZak(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);

            command.CommandText = "SELECT * FROM закупка WHERE `Код закупки`=@VALUE";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int count = (int)reader["Кол-во"];
                int np = (int)reader["Код НП"];
                int skl = (int)reader["Код склада"];
                reader.Close();

                List<int> z = new List<int> { np, count, skl };
                Connection.Close();
                MinusZapas(z);
            }

            Connection.Open();
            command.CommandText = "DELETE FROM kyrsovaya.закупка WHERE `Код закупки` = @VALUE;";
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public static void AddZak(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    Connection.Close();
                    return;
                }
            }
            command.Parameters.AddWithValue("@np", Int32.Parse(q[0]));
            command.Parameters.AddWithValue("@col", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@skl", Int32.Parse(q[2]));
            command.Parameters.AddWithValue("@dat", DateTime.Parse(q[3]));
            command.CommandText = "INSERT INTO закупка (`Кол-во`, Дата, `Код НП`, `Код склада`)  VALUES (@col, @dat, @np, @skl);";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
            List<int> z = new List<int>();
            for (int i = 0; i < q.Count-1; i++)
            {
                z.Add(Int32.Parse(q[i]));
            }
            Connection.Close();
            PlusZapas(z);
        }
        public static void EditZak(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    return;
                }
            }
            command.Parameters.AddWithValue("@id", Int32.Parse(q[0]));
            command.Parameters.AddWithValue("@np", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@col", Int32.Parse(q[2]));
            command.Parameters.AddWithValue("@skl", Int32.Parse(q[3]));
            command.Parameters.AddWithValue("@dat", DateTime.Parse(q[4]));
            command.CommandText = "UPDATE закупка SET `Кол-во` = @col,  Дата = @dat, `Код НП` = @np, `Код склада` = @skl WHERE `Код закупки` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
            }
            List<int> z = new List<int>();
            for (int i = 0; i < q.Count-1; i++)
            {
                z.Add(Int32.Parse(q[i]));
            }
            z.RemoveAt(0);
            Connection.Close();
            PlusZapas(z);
        }
        public static List<List<string>> ShowZak()
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();            
            command.CommandText = "SELECT SUM(з.`Кол-во`) AS q, з.`Код НП` FROM запас з GROUP BY з.`Код НП`";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код НП"].ToString());
                d[i].Add(reader["q"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }

        public static void DeleteReal(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);

            command.CommandText = "SELECT * FROM реализация WHERE `Код реализации`=@VALUE";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int count = (int)reader["Кол-во"];
                int np = (int)reader["Код НП"];
                int skl = (int)reader["Код склада"];
                reader.Close();

                List<int> z = new List<int> { np, count, skl };
                Connection.Close();
                PlusZapas(z);
            }

            Connection.Open();
            command.CommandText = "DELETE FROM kyrsovaya.реализация WHERE `Код реализации` = @VALUE;";
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public static void AddReal(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            int c;
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    Connection.Close();
                    return;
                }
                if(!Int32.TryParse(q[i], out c))
                {
                    MessageBox.Show("Не все данные заполнены корректно");
                    Connection.Close();
                    return;
                }
            }
            List<int> z = new List<int>();
            z.Add(Int32.Parse(q[0]));
            z.Add(Int32.Parse(q[2]));
            z.Add(Int32.Parse(q[1]));

            Connection.Close();
            bool check = MinusZapas(z);
            if (check)
            {
                Connection.Open();
                command.Parameters.AddWithValue("@np", Int32.Parse(q[0]));
                command.Parameters.AddWithValue("@col", Int32.Parse(q[2]));
                command.Parameters.AddWithValue("@skl", Int32.Parse(q[1]));
                command.CommandText = "INSERT INTO реализация (`Код НП`, `Кол-во`, `Код склада`)  VALUES (@np, @col, @skl);";
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавление произошло успешно");
                    Connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("При добавлении произошла ошибка");
                    Connection.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такого кол-ва нп нет на складе");
                Connection.Close();
                return;
            }
            
        }
        public static void EditReal(List<string> q, List<int> zap)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            int c;
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    Connection.Close();
                    return;
                }
                if (!Int32.TryParse(q[i], out c))
                {
                    MessageBox.Show("Не все данные заполнены корректно");
                    Connection.Close();
                    return;
                }
            }

            List<int> z = new List<int>();
            z.Add(Int32.Parse(q[1]));
            z.Add(Int32.Parse(q[3]));
            z.Add(Int32.Parse(q[2]));

            Connection.Close();
            PlusZapas(zap);
            bool check = MinusZapas(z);
            if (check)
            {
                Connection.Open();
                command.Parameters.AddWithValue("@id", Int32.Parse(q[0]));
                command.Parameters.AddWithValue("@np", Int32.Parse(q[1]));
                command.Parameters.AddWithValue("@skl", Int32.Parse(q[2]));
                command.Parameters.AddWithValue("@col", Int32.Parse(q[3]));
                command.CommandText = "UPDATE реализация SET `Код НП` = @np,    `Кол-во` = @col,    `Код склада` = @skl WHERE `Код реализации` = @id ";
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Изменение произошло успешно");
                    Connection.Close();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("При изменении произошла ошибка");
                    Connection.Close();
                    MinusZapas(zap);
                    
                    return;
                }
            }
            else
            {
                MinusZapas(zap);
                MessageBox.Show("Такого кол-ва нп нет на складе");
                return;
            }           
        }
        
        public static void AddTK(List<string> d)
        {
            int id = MaxIDTK()+1;
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@date", d[0]);
            command.Parameters.AddWithValue("@status", d[1]);
            command.CommandText = "INSERT INTO тк (`Код ТК`, `Дата изменения`, Статус)  VALUES(@id, @date, @status); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditTK(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@date", d[1]);
            command.Parameters.AddWithValue("@status", d[2]);
            command.CommandText = "UPDATE тк SET `Дата изменения` = @date, `Статус` = @status WHERE `Код ТК` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void DeleteTK(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM тк WHERE `Код ТК`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                command.CommandText = "DELETE FROM `состав тк` WHERE `Код ТК`= @VALUE;";
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }

        public static void DeleteTKS(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `состав тк` WHERE `Код ТК`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void DeleteTKO(int t, int o)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@t", t);
            command.Parameters.AddWithValue("@o", o);
            command.CommandText = "DELETE FROM `состав тк` WHERE `Код ТК`=@t AND `Номер операции`=@o;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void AddTKO(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@tk", d[0]);
            command.Parameters.AddWithValue("@op", d[1]);
            command.Parameters.AddWithValue("@rc", d[2]);
            command.Parameters.AddWithValue("@per", d[3]);
            command.Parameters.AddWithValue("@pod", d[4]);
            command.Parameters.AddWithValue("@rab", d[5]);
            command.Parameters.AddWithValue("@opis", d[6]);
            command.CommandText = "INSERT INTO `состав тк` (`Код ТК`, `Номер операции`, `Номер РЦ`, `Время перевода`, `Время подготовки`, `Время работы`, Описание) VALUES(@tk, @op, @rc, @per, @pod, @rab, @opis); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("При добавлении произошла ошибка" + e.ToString());
                Connection.Close();
                return;
            }
        }
        public static void EditTKO(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@tk", d[0]);
            command.Parameters.AddWithValue("@op", d[1]);
            command.Parameters.AddWithValue("@rc", d[2]);
            command.Parameters.AddWithValue("@per", d[3]);
            command.Parameters.AddWithValue("@pod", d[4]);
            command.Parameters.AddWithValue("@rab", d[5]);
            command.Parameters.AddWithValue("@opis", d[6]);
            command.CommandText = "UPDATE `состав тк` SET `Номер РЦ` = @rc,`Время перевода` = @per, `Время подготовки` = @pod, `Время работы` = @rab, `Описание` = @opis WHERE `Код ТК` = @tk AND `Номер операции` = @op;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
                Connection.Close();
                return;
            }
        }

        public static List<List<string>> ShowTKS(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `состав тк` WHERE `Код ТК`=@id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код ТК"].ToString());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Номер РЦ"].ToString());
                d[i].Add(reader["Время перевода"].ToString());
                d[i].Add(reader["Время подготовки"].ToString());
                d[i].Add(reader["Время работы"].ToString());
                d[i].Add(reader["Описание"].ToString());
                
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }
        public static int MaxTKO(int i)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", i);
            command.CommandText = "SELECT MAX(`Номер операции`) AS q FROM `состав тк` WHERE `Код ТК`=@id";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader["q"].ToString() != "")
                {
                    int max = Int32.Parse(reader["q"].ToString())+1 ;
                    reader.Close();
                    Connection.Close();
                    return max ;
                }
                else
                {
                    reader.Close();
                    Connection.Close();
                    return 1;
                }
                
            }
            reader.Close();
            Connection.Close();
            return -1;
        }
        public static int MaxIDTK()
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT MAX(`Код ТК`) AS q FROM тк ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int max = (int)reader["q"];
                reader.Close();
                Connection.Close();
                return max;
            }
            reader.Close();
            Connection.Close();
            return -1;
        }

        public static void DeleteSpec(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `состав спецификации` WHERE `Код спецификации`= @VALUE;";
            
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                command.CommandText = "DELETE FROM спецификация WHERE `Код спецификации`= @VALUE;";
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void AddSpec(List<string> d)
        {
            int id = MaxIDSPEC();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@date", d[0]);
            command.Parameters.AddWithValue("@status", d[1]);
            command.CommandText = "INSERT INTO спецификация (`Код спецификации`, `Дата изменения`, Статус)  VALUES(@id, @date, @status); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EdiSPEC(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@date", d[1]);
            command.Parameters.AddWithValue("@status", d[2]);
            command.CommandText = "UPDATE спецификация SET `Дата изменения` = @date, `Статус` = @status WHERE `Код спецификации` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
                Connection.Close();
                return;
            }
        }

        public static int MaxIDSPEC()
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT MAX(`Код спецификации`) AS q FROM спецификация";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int max = (int)reader["q"];
                reader.Close();
                Connection.Close();
                return max+1;
            }
            reader.Close();
            Connection.Close();
            return -1;
        }
        public static List<List<string>> ShowSPO(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `состав спецификации` WHERE `Код спецификации`=@id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код спецификации"].ToString());
                d[i].Add(reader["Код НП"].ToString());
                d[i].Add(reader["Порядковый номер"].ToString());
                d[i].Add(reader["Кол-во"].ToString());
                d[i].Add(reader["Ед. изм"].ToString());

                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }
        public static void DeleteSPS(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `состав спецификации` WHERE `Код спецификации`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void DeleteSPO(int s, int n)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@S", s);
            command.Parameters.AddWithValue("@N", n);
            command.CommandText = "DELETE FROM `состав спецификации` WHERE `Код спецификации`=@S AND `Код НП`=@N;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void AddSPO(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@sp", d[0]);
            command.Parameters.AddWithValue("@np", d[1]);
            command.Parameters.AddWithValue("@pn", d[2]);
            command.Parameters.AddWithValue("@col", d[3]);
            command.Parameters.AddWithValue("@ed", d[4]);
            command.CommandText = "INSERT INTO `состав спецификации` (`Код спецификации`, `Код НП`, `Порядковый номер`, `Кол-во`, `Ед. изм`) VALUES(@sp, @np, @pn, @col, @ed); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditSPO(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@sp", d[0]);
            command.Parameters.AddWithValue("@np", d[1]);
            command.Parameters.AddWithValue("@pn", d[2]);
            command.Parameters.AddWithValue("@col", d[3]);
            command.Parameters.AddWithValue("@ed", d[4]);
            command.CommandText = "UPDATE `состав спецификации` SET `Порядковый номер` = @pn,`Кол-во` = @col, `Ед. изм` = @ed WHERE `Код спецификации` = @sp AND `Код НП` = @np;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
                Connection.Close();
                return;
            }
        }

        public static void DeleteNP(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `нп` WHERE `Код НП`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static int MaxIDNP()
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT MAX(`Код НП`) AS q FROM нп";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int max = (int)reader["q"];
                reader.Close();
                Connection.Close();
                return max + 1;
            }
            reader.Close();
            Connection.Close();
            return -1;
        }
        public static void AddNP(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            if (d[2] != "") command.Parameters.AddWithValue("@doz", d[2]);
            else command.Parameters.AddWithValue("@doz", null);
            if (d[3] != "") command.Parameters.AddWithValue("@tochka", d[3]);
            else command.Parameters.AddWithValue("@tochka", null);
            command.Parameters.AddWithValue("@voz", d[4]);
            command.Parameters.AddWithValue("@naim", d[1]);
            command.Parameters.AddWithValue("@edIzm", d[5]);
            if (d[6] != "") command.Parameters.AddWithValue("@perOj", d[6]);
            else command.Parameters.AddWithValue("@perOj", null);
            if (d[8] != "") command.Parameters.AddWithValue("@spec", d[8]);
            else command.Parameters.AddWithValue("@spec", null);
            if (d[7] != "") command.Parameters.AddWithValue("@tk", d[7]);
            else command.Parameters.AddWithValue("@tk", null);
            command.CommandText = "INSERT INTO нп (`Код НП`, `Кол-во дозаказа`, `Точка дозаказа`, `Метод возобновления`, `Наименование`, `Ед. имзерения`, `Период ожидания (дни)`, `Код спецификации`, `Код ТК`) VALUES (@id, @doz, @tochka, @voz, @naim, @edIzm, @perOj, @spec, @tk); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditNP(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            if(d[2]!="") command.Parameters.AddWithValue("@doz", d[2]);
            else command.Parameters.AddWithValue("@doz", null);
            if (d[3] != "") command.Parameters.AddWithValue("@tochka", d[3]);
            else command.Parameters.AddWithValue("@tochka", null);
            command.Parameters.AddWithValue("@voz", d[4]);
            command.Parameters.AddWithValue("@naim", d[1]);
            command.Parameters.AddWithValue("@edIzm", d[5]);
            if (d[6] != "") command.Parameters.AddWithValue("@perOj", d[6]);
            else command.Parameters.AddWithValue("@perOj", null);
            if (d[8] != "") command.Parameters.AddWithValue("@spec", d[8]);
            else command.Parameters.AddWithValue("@spec", null);
            if (d[7] != "") command.Parameters.AddWithValue("@tk", d[7]);
            else command.Parameters.AddWithValue("@tk", null);
            command.CommandText = "UPDATE нп SET `Кол-во дозаказа` = @doz, `Точка дозаказа` = @tochka, `Метод возобновления` = @voz, `Наименование` = @naim, `Ед. имзерения` = @edIzm, `Период ожидания (дни)` = @perOj, `Код спецификации` = @spec, `Код ТК` = @tk WHERE `Код НП` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception e )
            {
                MessageBox.Show("При изменении произошла ошибка" + e);
                Connection.Close();
                return;
            }
        }

        public static void DeleteRC(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `рц` WHERE `Номер РЦ`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static int MaxIDRC()
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT MAX(`Номер РЦ`) AS q FROM рц";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int max = (int)reader["q"];
                reader.Close();
                Connection.Close();
                return max + 1;
            }
            reader.Close();
            Connection.Close();
            return -1;
        }
        public static void AddRC(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@op", d[1]);
            command.Parameters.AddWithValue("@m", d[2]);
            command.CommandText = "INSERT INTO рц (`Номер РЦ`, `Описание`, `Мощность`) VALUES(@id, @op, @m); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditRC(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@op", d[1]);
            command.Parameters.AddWithValue("@m", d[2]);
            command.CommandText = "UPDATE рц SET `Описание` = @op, `Мощность` = @m WHERE `Номер РЦ` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("При изменении произошла ошибка" + e);
                Connection.Close();
                return;
            }
        }

        public static void AddPZ(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@np", d[1]);
            command.Parameters.AddWithValue("@col", d[2]);
            command.Parameters.AddWithValue("@sozd", d[3]);
            if (d[4] != " ") command.Parameters.AddWithValue("@zav", d[4]);
            else command.Parameters.AddWithValue("@zav", null);
            command.CommandText = "INSERT INTO `производственный заказ` (`Код ПЗ`, `Кол-во`, `Дата создания`, `Дата завершения`, `Код НП`) VALUES (@id, @col, @sozd, @zav, @np); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditPZ(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@np", d[1]);
            command.Parameters.AddWithValue("@col", d[2]);
            command.Parameters.AddWithValue("@sozd", d[3]);
            if (d[4] != null) command.Parameters.AddWithValue("@zav", d[4]);
            else command.Parameters.AddWithValue("@zav", null);
            command.CommandText = "UPDATE `производственный заказ` SET `Кол-во` = @col, `Дата создания` = @sozd, `Дата завершения` = @zav, `Код НП` = @np WHERE `Код ПЗ` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("При изменении произошла ошибка" + e);
                Connection.Close();
                return;
            }
        }
        public static int MaxIDPZ()
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT MAX(`Код ПЗ`) AS q FROM `производственный заказ`";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int max = (int)reader["q"];
                reader.Close();
                Connection.Close();
                return max + 1;
            }
            reader.Close();
            Connection.Close();
            return -1;
        }
        public static int MaxIDTKPZ()
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT MAX(`Код ТК ПЗ`) AS q FROM `тк пз` ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int max = (int)reader["q"];
                reader.Close();
                Connection.Close();
                return max;
            }
            reader.Close();
            Connection.Close();
            return -1;
        }


        public static void DeleteTKPZ(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `тк пз` WHERE `Код ТК ПЗ`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void AddTKPZ(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@pz", d[0]);
            command.Parameters.AddWithValue("@date", d[1]);
            command.CommandText = "INSERT INTO `тк пз` (`Дата изменения`, `Код ПЗ`) VALUES (@date, @pz); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditPZTK(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@pz", d[0]);
            command.Parameters.AddWithValue("@id", d[1]);
            command.Parameters.AddWithValue("@date", d[2]);

            command.CommandText = "UPDATE `тк пз`  SET `Дата изменения` = @date WHERE `Код ТК ПЗ` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("При изменении произошла ошибка" + e);
                Connection.Close();
                return;
            }
        }

        public static void DeleteTKPZOP(int i, int o)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@i", i);
            command.Parameters.AddWithValue("@o", o);
            command.CommandText = "DELETE FROM `состав тк пз` WHERE `Код ТК ПЗ`=@i AND `Номер операции`=@o;";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При удалении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void AddTKPZOP(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@op", d[1]);
            command.Parameters.AddWithValue("@rc", d[2]);
            command.Parameters.AddWithValue("@per", d[3]);
            command.Parameters.AddWithValue("@pod", d[4]);
            command.Parameters.AddWithValue("@rab", d[5]);
            command.Parameters.AddWithValue("@opis", d[6]);
            if (d[4] != null) command.Parameters.AddWithValue("@zav", d[4]);
            else command.Parameters.AddWithValue("@zav", null);
            command.CommandText = "INSERT INTO `состав тк пз` (`Код ТК ПЗ`, `Номер РЦ`, `Время перевода`, `Время подготовки`, `Время работы`, `Описание`, `Номер операции`) VALUES (@id, @rc, @per, @pod, @rab, @opis, @op); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
        }
        public static void EditPZTKOP(List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", d[0]);
            command.Parameters.AddWithValue("@op", d[1]);
            command.Parameters.AddWithValue("@rc", d[2]);
            command.Parameters.AddWithValue("@per", d[3]);
            command.Parameters.AddWithValue("@pod", d[4]);
            command.Parameters.AddWithValue("@rab", d[5]);
            command.Parameters.AddWithValue("@opis", d[6]);

            command.CommandText = "UPDATE `состав тк пз`  SET  `Номер РЦ` = @rc, `Время перевода` = @per, `Время подготовки` = @pod, `Время работы` = @rab, Описание = @opis, `Номер операции` = @op WHERE `Код ТК ПЗ` = @id AND `Номер операции` = @op; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("При изменении произошла ошибка" + e);
                Connection.Close();
                return;
            }
        }

        public static List<List<string>> ShowSostavTKPZ(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `состав тк` ст WHERE ст.`Код ТК`= (SELECT н.`Код ТК` FROM нп н WHERE н.`Код НП`=(SELECT пз.`Код НП` FROM `производственный заказ` пз WHERE пз.`Код ПЗ`=@id))";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Номер РЦ"].ToString());
                d[i].Add(reader["Время перевода"].ToString());
                d[i].Add(reader["Время подготовки"].ToString());
                d[i].Add(reader["Время работы"].ToString());
                d[i].Add(reader["Описание"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }
        public static List<List<string>> ShowTKPZOPP(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `состав тк пз` WHERE `Код ТК ПЗ`=@id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код ТК ПЗ"].ToString());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Номер РЦ"].ToString());
                d[i].Add(reader["Время перевода"].ToString());
                d[i].Add(reader["Время подготовки"].ToString());
                d[i].Add(reader["Время работы"].ToString());
                d[i].Add(reader["Описание"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }
        public static void AddOP(int tk, List<string> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", tk);
            command.Parameters.AddWithValue("@op", d[0]);
            command.Parameters.AddWithValue("@rc", d[1]);
            command.Parameters.AddWithValue("@per", d[2]);
            command.Parameters.AddWithValue("@pod", d[3]);
            command.Parameters.AddWithValue("@rab", d[4]);
            command.Parameters.AddWithValue("@opis", d[5]);
            command.CommandText = "INSERT INTO `состав тк пз` (`Код ТК ПЗ`, `Номер РЦ`, `Время перевода`, `Время подготовки`, `Время работы`, `Описание`, `Номер операции`) VALUES (@id, @rc, @per, @pod, @rab, @opis, @op); ";
            try
            {
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                Connection.Close();
                return;
            }
        }
        public static void DeleteSost(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `состав тк пз` WHERE `Код ТК ПЗ`= @VALUE;";
            try
            {
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                Connection.Close();
                return;
            }
        }

        public static List<List<string>> ShowTKPZ(int id)
        {
            fromTK = false;
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `тк пз` WHERE `Код ПЗ`= @id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код ПЗ"].ToString());
                d[i].Add(reader["Код ТК ПЗ"].ToString());
                d[i].Add(reader["Дата изменения"].ToString());
                i++;
            }
            reader.Close();

            if (i == 0)
            {
                fromTK = true;
                command.CommandText = "SELECT `Код НП` FROM `производственный заказ` WHERE `Код ПЗ`= @id";
                reader = command.ExecuteReader();
                reader.Read();
                int np = Int32.Parse(reader["Код НП"].ToString());
                reader.Close();
                command.Parameters.AddWithValue("@np", np);
                command.CommandText = "SELECT `Код ТК` FROM нп WHERE `Код НП`= @np";
                reader = command.ExecuteReader();
                reader.Read();
                int tk = Int32.Parse(reader["Код ТК"].ToString());
                reader.Close();
                command.Parameters.AddWithValue("@tk", tk);
                command.CommandText = "SELECT `Код ТК`, `Дата изменения`, `Статус` FROM тк WHERE `Код ТК`= @tk";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    d.Add(new List<string>());
                    d[i].Add(id.ToString());
                    d[i].Add(reader["Код ТК"].ToString());
                    d[i].Add(reader["Дата изменения"].ToString());
                    i++;
                }
            }
            Connection.Close();
            return d;
        }

        public static List<List<string>> ShowTKPZOP(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `состав тк пз` WHERE `Код ТК ПЗ`= @id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код ТК ПЗ"].ToString());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Номер РЦ"].ToString());
                d[i].Add(reader["Время перевода"].ToString());
                d[i].Add(reader["Время подготовки"].ToString());
                d[i].Add(reader["Время работы"].ToString());
                d[i].Add(reader["Описание"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }
        public static List<List<string>> ShowTKOP(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `состав тк` WHERE `Код ТК`= @id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код ТК"].ToString());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Номер РЦ"].ToString());
                d[i].Add(reader["Время перевода"].ToString());
                d[i].Add(reader["Время подготовки"].ToString());
                d[i].Add(reader["Время работы"].ToString());
                d[i].Add(reader["Описание"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }
        public static List<List<string>> ShowVP(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `выполненные операции` WHERE `Код ПЗ`= @id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код выполн. операций"].ToString());
                d[i].Add(reader["Код ПЗ"].ToString());
                d[i].Add(reader["Код ТК"].ToString());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Потраченное время"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }

        public static void AddVP(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@pz", Int32.Parse(q[0]));
            command.CommandText = "SELECT `Код НП` FROM `производственный заказ` WHERE `Код ПЗ`=@pz";
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int np = Int32.Parse(reader["Код НП"].ToString());
            reader.Close();
            command.Parameters.AddWithValue("@np", np);
            command.CommandText = "SELECT `Код спецификации` FROM нп WHERE `Код НП`=@np";
            reader = command.ExecuteReader();
            reader.Read();
            int spec = Int32.Parse(reader["Код спецификации"].ToString());
            reader.Close();

            command.Parameters.AddWithValue("@no", Int32.Parse(q[2]));
            command.Parameters.AddWithValue("@spec", spec);
            command.CommandText = "SELECT * FROM `состав спецификации` сс WHERE сс.`Код спецификации`=@spec AND сс.`Порядковый номер`=@no";
            reader = command.ExecuteReader();
            int i = 0;
            List<List<int>> z = new List<List<int>>();
            bool check = true;
            while (reader.Read()&&check)
            {
                z.Add(new List<int>());
                z[i].Add(Int32.Parse(reader["Код НП"].ToString()));
                z[i].Add(Int32.Parse(reader["Кол-во"].ToString()));
                i++;
            }
            reader.Close();
            Connection.Close();
            check = SpisanieZapas(z, Int32.Parse(q[0]), Int32.Parse(q[1]), Int32.Parse(q[2]));


            if (check)
            {
                Connection.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pz", Int32.Parse(q[0]));
                command.Parameters.AddWithValue("@tk", Int32.Parse(q[1]));
                command.Parameters.AddWithValue("@no", Int32.Parse(q[2]));
                command.Parameters.AddWithValue("@vr", Int32.Parse(q[3]));
                command.CommandText = "INSERT INTO `выполненные операции` (`Код ПЗ`, `Потраченное время`, `Код ТК`, `Номер операции`) VALUES(@pz, @vr, @tk, @no); ";
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Операция выполнена произошло успешно");
                    Connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("При выполнении что-то пошло не так");
                    Connection.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такого кол-ва нп нет на складе");
                Connection.Close();
                return;
            }

        }

        public static void DeleteVP(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@pz", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@no", Int32.Parse(q[2]));
            command.CommandText = "SELECT * FROM `журнал потребления` WHERE `Код ПЗ`=@pz AND `Номер операции`=@no";
            MySqlDataReader reader = command.ExecuteReader();
            List<List<int>> z = new List<List<int>>();
            int i = 0;
            while (reader.Read())
            {
                z.Add(new List<int>());
                z[i].Add(Int32.Parse(reader["Код потребления"].ToString()));
                z[i].Add(Int32.Parse(reader["Код НП"].ToString()));
                z[i].Add(Int32.Parse(reader["Количество"].ToString()));
                i++;
            }
            reader.Close();
            Connection.Close();
            DobavlZapas(z, Int32.Parse(q[1]));

            Connection.Open();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Int32.Parse(q[0]));

                command.CommandText = "DELETE FROM `выполненные операции` WHERE `Код выполн. операций`=@id ";
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Удаление произошло успешно");
                    Connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("При выполнении что-то пошло не так");
                    Connection.Close();
                    return;
                }
            
            
            

        }

        public static void AddJurn(List<int> d, int p, int t, int o)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@p", p);
            command.Parameters.AddWithValue("@t", t);
            command.Parameters.AddWithValue("@no", o);
            command.Parameters.AddWithValue("@np", d[0]);
            command.Parameters.AddWithValue("@col", d[1]);
            command.Parameters.AddWithValue("@skl", d[2]);
            command.CommandText = "INSERT INTO `журнал потребления` (`Количество`, `Код ПЗ`, `Код НП`, `Код ТК`, `Номер операции`) VALUES(@col, @p, @np, @t, @no); ";
            try
            {
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                Connection.Close();
                return;
            }
        }
        public static void DeletePZ(int id)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            command.CommandText = "DELETE FROM `производственный заказ` WHERE `Код ПЗ`= @VALUE;";           
            try
            {
                command.ExecuteNonQuery();               
                MessageBox.Show("Удаление произошло успешно");
                Connection.Close();
                return;
            }
            catch (Exception)
            {
                try
                {
                    command.CommandText = "DELETE FROM `выход гп` WHERE `Код ПЗ`= @VALUE;";
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                }
                try
                {
                    command.CommandText = "DELETE FROM `журнал потребления` WHERE `Код ПЗ`= @VALUE;";
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                }
                try
                {
                    command.CommandText = "DELETE FROM `выполненные операции` WHERE `Код ПЗ`= @VALUE;";
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                }
                try
                {
                    command.CommandText = "DELETE FROM `производственный заказ` WHERE `Код ПЗ`= @VALUE;";
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("При удалении произошла ошибка");
                    Connection.Close();
                    return;
                }  
            }
            MessageBox.Show("Удаление произошло успешно");
            Connection.Close();
        }

        public static void DeleteVihod(int id, List<int> d)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@VALUE", id);
            Connection.Close();
            MinusZapas(d);
            Connection.Open();
            command.CommandText = "DELETE FROM `выход гп` WHERE `Код выхода`= @VALUE;";
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public static void EditVihod(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    return;
                }
            }
            command.Parameters.AddWithValue("@id", Int32.Parse(q[0]));
            command.Parameters.AddWithValue("@pz", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@np", Int32.Parse(q[2]));
            command.Parameters.AddWithValue("@col", Int32.Parse(q[3]));
            command.Parameters.AddWithValue("@skl", Int32.Parse(q[4]));
            command.CommandText = "UPDATE `выход гп` SET `Количество` = @col, `Код склада` = @skl, `Код НП` = @np WHERE `Код выхода` = @id; ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение произошло успешно");
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении произошла ошибка");
            }
            List<int> z = new List<int>();
            for (int i = 2; i < q.Count; i++)
            {
                z.Add(Int32.Parse(q[i]));
            }
            Connection.Close();
            PlusZapas(z);
        }
        public static void AddVihod(List<string> q)
        {
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] == "")
                {
                    MessageBox.Show("Не все данные заполнены");
                    Connection.Close();
                    return;
                }
            }
            command.Parameters.AddWithValue("@pz", Int32.Parse(q[0]));
            command.Parameters.AddWithValue("@np", Int32.Parse(q[1]));
            command.Parameters.AddWithValue("@col", Int32.Parse(q[2]));
            command.Parameters.AddWithValue("@skl", Int32.Parse(q[3]));
            command.CommandText = "INSERT INTO `выход гп` (Количество, `Код склада`, `Код НП`, `Код ПЗ`) VALUES(@col, @skl, @np, @pz); ";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление произошло успешно");
            }
            catch (Exception)
            {
                MessageBox.Show("При добавлении произошла ошибка");
                Connection.Close();
                return;
            }
            List<int> z = new List<int>();
            for (int i = 1; i < q.Count; i++)
            {
                z.Add(Int32.Parse(q[i]));
            }
            Connection.Close();
            PlusZapas(z);
        }

        public static List<List<string>> ShowBron()
        {
            List<List<string>> d = new List<List<string>>();
            List<List<int>> pz = new List<List<int>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT `Код ПЗ`, `Кол-во`, `Код НП` FROM `производственный заказ` WHERE `Дата завершения` IS NULL";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                pz.Add(new List<int>());
                pz[i].Add(int.Parse(reader["Код ПЗ"].ToString()));
                pz[i].Add(int.Parse(reader["Код НП"].ToString()));
                pz[i].Add(int.Parse(reader["Кол-во"].ToString()));
                i++;
            }
            reader.Close();
            int q = 0;
            for(int j = 0; j < pz.Count; j++)
            {
                command.Parameters.AddWithValue("@np", Int32.Parse(pz[j][1].ToString()));
                command.CommandText = "SELECT `Код спецификации` FROM нп WHERE `Код НП`=@np";
                reader = command.ExecuteReader();
                reader.Read();
                int sp = int.Parse(reader["Код спецификации"].ToString());
                reader.Close();

                command.Parameters.AddWithValue("@sp", sp);
                command.CommandText = "SELECT сс.`Код НП`, сс.`Кол-во` FROM `состав спецификации` сс WHERE сс.`Код спецификации` = @sp";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    d.Add(new List<string>());
                    d[q].Add(pz[j][0].ToString());
                    d[q].Add(reader["Код НП"].ToString());
                    d[q].Add(reader["Кол-во"].ToString());
                    q++;
                }
                reader.Close();
                command.Parameters.Clear();
            }

            return d;
        }

        public static List<List<string>> ShowPOT(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `журнал потребления` WHERE `Код ПЗ`= @id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код потребления"].ToString());
                d[i].Add(reader["Код ПЗ"].ToString());
                d[i].Add(reader["Код НП"].ToString());
                d[i].Add(reader["Код ТК"].ToString());
                d[i].Add(reader["Номер операции"].ToString());
                d[i].Add(reader["Количество"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }

        public static List<List<string>> ShowVIH(int id)
        {
            List<List<string>> d = new List<List<string>>();
            Connection.Open();
            MySqlCommand command = Connection.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "SELECT * FROM `выход гп` WHERE `Код ПЗ`= @id";
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                d.Add(new List<string>());
                d[i].Add(reader["Код выхода"].ToString());
                d[i].Add(reader["Код ПЗ"].ToString());
                d[i].Add(reader["Код НП"].ToString());
                d[i].Add(reader["Количество"].ToString());
                d[i].Add(reader["Код склада"].ToString());
                i++;
            }
            reader.Close();
            Connection.Close();
            return d;
        }

    }
}

