using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

public class Class1
{
    public void VisualizzaCSV()
    {
        listView1.Clear();
        using (StreamReader sr = new StreamReader(FileName))
        {
            string a = sr.ReadLine();
            string[] campi = a.Split(';');
            for (int i = 0; i < campi.Length; i++)
            {
                listView1.Columns.Add(campi[i]);
            }
            while (sr.Peek() != -1)
            {
                string b = sr.ReadLine();
                string[] campi2 = b.Split(';');
                ListViewItem item = new ListViewItem(campi2);
                listView1.Items.Add(item);
            }
        }
    }

    public void Aggiunta_valore()
    {
        string[] lines = File.ReadAllLines(FileName);

        StreamWriter writer = new StreamWriter(FileName);
        writer.WriteLine(lines[0] + ";" + "Mio valore");
        for (int i = 0; i < lines.Length; i++)
        {
            writer.WriteLine(lines[i] + ";" + rnd.Next(10, 21)+";1");
        }
        writer.Close();
    }

    public void ContaCampi()
    {
        using (StreamReader sr = new StreamReader(FileName))
        {
            int n = 0;
            string a = sr.ReadLine();
            string[] campi = a.Split(';');
            for (int i = 0; i < campi.Length; i++)
            {
                n++;
            }

            MessageBox.Show("Il numero di campi è " + (n.ToString()));
        }
    }

    public int Lunghezzamassimacampi()
    {
        int max = 0;
        using (StreamReader sr = new StreamReader(FileName))
        {
            string a = sr.ReadLine();
            string[] campi = a.Split(';');
            for (int i = 0; i < campi.Length; i++)
            {
                if (campi[i].Length > max)
                {
                    max = campi[i].Length;
                }
            }
            MessageBox.Show("La lunghezza massima dei campi è " + (max.ToString()));

            return max;
        }
    }

    public void DimFissa()
    {
        string s;
        int i = 0;
        StreamReader reader = new StreamReader(FileName);
        StreamWriter writer = new StreamWriter("bassanelli2.csv");


        s = reader.ReadLine();
        while (s != null)
        {
            if (i != 0)
            {
                writer.WriteLine(s.PadRight(300));
            }
            else
            {
                writer.WriteLine(s);
            }

            s = reader.ReadLine();
            i++;
        }

        reader.Close();
        writer.Close();

        File.Replace("bassanelli2.csv", FileName, "prova.csv");
    }

    public void Recordcoda(string comunetextBox1, string provinciatextBox2, string regionetextBox3, string nometextBox4, string annotextBox5, string datatextBox6, string identificatoretextBox7, string longitudinetextBox8, string latitudinetextBox9)
    {
        StreamReader reader = new StreamReader(Filename2);
        StreamWriter writer = new StreamWriter(FileName);

        string s = reader.ReadLine();
        while (s != null)
        {
            writer.WriteLine(s);
            s = reader.ReadLine();
        }

        writer.WriteLine(comunetextBox1 + ";" + provinciatextBox2 + ";" + regionetextBox3 + ";" + nometextBox4 + ";" + annotextBox5 + ";" + datatextBox6 + ";" + identificatoretextBox7 + ";" + longitudinetextBox8 + ";" + latitudinetextBox9);

        reader.Close();
        writer.Close();
    }

    public void VisualizzaDatiSignificativi()
    {
        listView1.Clear();
        using (StreamReader sr = new StreamReader(FileName))
        {
            string a = sr.ReadLine();
            string[] campi = a.Split(';');
            for (int i = 0; i < campi.Length; i++)
            {
                listView1.Columns.Add(campi[i]);
            }
            while (sr.Peek() != -1)
            {
                string b = sr.ReadLine();
                string[] campi2 = b.Split(';');
                ListViewItem item = new ListViewItem(campi2[0]);
                item.SubItems.Add(campi2[2]);
                item.SubItems.Add(campi2[6]);
                listView1.Items.Add(item);
            }
        }
    }

    public void RicercaPerCampo()
    {
        listView1.Clear();
        using (StreamReader sr = new StreamReader(FileName))
        {
            string a = sr.ReadLine();
            string[] campi = a.Split(';');
            for (int i = 0; i < campi.Length; i++)
            {
                listView1.Columns.Add(campi[i]);
            }
            while (sr.Peek() != -1)
            {
                string b = sr.ReadLine();
                string[] campi2 = b.Split(';');
                if (campi2[0] == ricercatextBox10.Text)
                {
                    ListViewItem item = new ListViewItem(campi2[0]);
                    item.SubItems.Add(campi2[1]);
                    item.SubItems.Add(campi2[2]);
                    item.SubItems.Add(campi2[3]);
                    item.SubItems.Add(campi2[4]);
                    item.SubItems.Add(campi2[5]);
                    item.SubItems.Add(campi2[6]);
                    item.SubItems.Add(campi2[7]);
                    item.SubItems.Add(campi2[8]);
                    listView1.Items.Add(item);
                }
            }
        }

    }

    public void CancLogica()
    {
        StreamReader reader = new StreamReader(FileName);
        StreamWriter writer = new StreamWriter("bassanelli2.csv");
        string s = reader.ReadLine();
        string a = "";
        while (s != null)
        {
            string[] campi = s.Split(';');
            if (campi[6] == canclogicatextBox11.Text)
            {
                campi[campi.Length - 1] = "0";
                for (int i = 0; i < campi.Length; i++)
                {
                    if (i == campi.Length - 1)
                    {
                        s = s + campi[i];
                    }
                    else
                    {
                        s = s + campi[i] + ";";
                    }
                }
            }
            writer.WriteLine(s);
            s = reader.ReadLine();
        }
        reader.Close();
        writer.Close();
        File.Replace("bassanelli2.csv", FileName, "prova.csv");
    }

}
