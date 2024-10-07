using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;

namespace lab1_1
{
    class CollectionComparer : IEqualityComparer<IEnumerable<string>>
    {
        public bool Equals(IEnumerable<string> x, IEnumerable<string> y)
        {
            // Compare the collections of strings by checking if they have the same elements in the same order
            return x.SequenceEqual(y);
        }

        public int GetHashCode(IEnumerable<string> obj)
        {
            // Combine the hash codes of individual elements
            return obj.Aggregate(0, (hash, str) => hash ^ str.GetHashCode());
        }
    }

        public class time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public time(string point)
        {
            string[] parts = point.Split(':');
            hours = int.Parse(parts[0]);
            minutes = int.Parse(parts[1]);
            seconds = int.Parse(parts[2]);
        }
        
    }

    public class timeInvl
    {
        public time firstPoint;
        public time secondPoint;

        public timeInvl(string interval)
        {
            string[] halves = interval.Split('-');
            firstPoint = new time(halves[0]);
            secondPoint = new time(halves[1]);
        }
    }

    public class Validator
    {
        public static bool ValidateNameForPath(string name)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            foreach (char c in invalidChars)
            {
                if (name.Contains(c)) return false;
            }
            return true;
        }

        public static bool ValidateTime(string time)
        {
            string timePattern = @"^([01]\d|2[0-3]):([0-5]\d):([0-5]\d)$"; //перевірка коректності запису момента часу
            Regex regex = new Regex(timePattern);
            return regex.IsMatch(time);
        }

        public static bool ValidateTimeInterval(string time)
        {
            string timePattern = @"^([01]\d|2[0-3]):([0-5]\d):([0-5]\d)-([01]\d|2[0-3]):([0-5]\d):([0-5]\d)$"; //перевірка коректності запису інтервалу часу
            Regex regex = new Regex(timePattern);
            return regex.IsMatch(time);
        }
    }

    public class Database
    {
        public string Name;
        private Collection<Table> Tables = new Collection<Table> { };


        public Database(string name) { Name = name; }

        public void AddTable(Table table) { 
            Tables.Add(table);
            System.IO.File.Create("TextData\\" + Name + "\\" + table.Name + ".txt").Close();
            string tables="";
            foreach (Table t in Tables) tables = tables + t.Name + "\n";
            System.IO.File.WriteAllText("TextData\\" + Name + "\\tables.txt", tables);

            string schemes = "";
            
            foreach (Table t in Tables)
            {
                int j = 0;
                foreach ((string, string) s in t.Scheme) {
                    j++;
                    if (j == t.Scheme.Count) schemes = schemes + s.Item1 + "|" + s.Item2;
                    else schemes = schemes + s.Item1 + "|" + s.Item2 + "|"; 
                
                }
                schemes.Remove(schemes.Length-2);
                schemes += "\n";
            }
            System.IO.File.WriteAllText("TextData\\" + Name + "\\schemes.txt",schemes);
        }

        public IEnumerable<IEnumerable<string>> Intersect(Table leftTable, Table rightTable)
        {
            
            bool flag = false;
            leftTable.LoadEntries();
            rightTable.LoadEntries();
            Collection<Collection<string>> lEntries = new Collection<Collection<string>>();
            Collection<Collection<string>> rEntries = new Collection<Collection<string>>();

            foreach (Entry e in leftTable.GetEntries()) lEntries.Add(e.Content);
            foreach (Entry e in rightTable.GetEntries()) rEntries.Add(e.Content);

            IEnumerable<IEnumerable<string>> entries = lEntries.Intersect(rEntries, new CollectionComparer());

            return entries;
        }

        public bool DropTable(string tableName)
        {
            foreach (Table table in Tables) if (table.Name == tableName) { table.DropTable(); return true; }

            return false;
        }

        public Collection<Table> GetTables() { return Tables; }

        public void LoadTables(string pathTables, string pathSchemes)
        {
            string[] lines = System.IO.File.ReadAllLines(pathTables);
            string[] schemes = System.IO.File.ReadAllLines(pathSchemes);
            Collection<(string, string)> scheme = new Collection<(string, string)> { };
            Collection<Entry> entries = new Collection<Entry>();



            for (int i = 0; i < lines.Length; i++)
            {
                entries.Clear();
                scheme.Clear();

                string[] temp = System.IO.File.ReadAllLines("TextData\\" + Name + "\\" + lines[i] + ".txt");//усі ентрі
                foreach (string t in temp)
                {
                    string[] content = t.Split(' '); //кожне ентрі ділиться на стовпчики
                    Entry e = new Entry(content, lines[i]); //та створюється інстанс
                    entries.Add(e); //додається до ентрі таблиці
                }

                string[] tempScheme = schemes[i].Split('|');
                for (int j = 0; j < tempScheme.Length; j += 2)
                {
                    scheme.Add((tempScheme[j], tempScheme[j + 1]));

                }
                Table newTable = new Table(lines[i], scheme, Name);
                Tables.Add(newTable);

            }



        }


        public void SaveClean()
        {
            foreach (Table table in Tables) if (table.Dropped == true) Tables.Remove(table);
        }
    }


    public class Table
    {
        public string Name;
        public Collection<(string,string)> Scheme = new Collection<(string, string)>();
        private Collection<Entry> Entries = new Collection<Entry> { };
        public bool Dropped = false;
        public string DBName;

        public Table(string name,Collection<(string,string)> scheme,  string dbname)
        {
            Name = name;
            //foreach (Entry entry in entries) { Entries.Add(entry); }
            foreach ((string, string) s in scheme) { Scheme.Add(s); }
            DBName = dbname;
        }

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }

        public void EditEntry(int number, Entry edits)
        {
            //copying parameters from edits to entry number n in collection
        }

        public Collection<Entry> GetEntries()
        {
            return Entries;
        }

        public void LoadEntries()
        {
            Entries.Clear();
            string[] entries = System.IO.File.ReadAllLines("TextData\\" + DBName + "\\" + Name + ".txt");
            foreach (string entry in entries)
            {
                string[] entryContent = entry.Split('|');
                //Collection<string> content = new Collection<string>();
                //foreach (string line in entryContent) { content.Add(line); }
                Entry newEntry = new Entry(entryContent, Name);
                this.AddEntry(newEntry);
            }
        }

        public void DropTable() { Dropped = true; }
    }


    


    public class Entry
    {
        public Collection<string> Content = new Collection<string> (); //колекція значень стовпців
        public string TableName;

        public Entry(string[] content, string tableName)
        {
            for (int i=0; i<content.Length; i++)
            {
                Content.Add(content[i]);
            }
            TableName = tableName;
        }
    }


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndexForm());
        }
    }
}
