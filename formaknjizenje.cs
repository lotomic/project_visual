using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIM18_racunovodstvo
{
    public partial class formaknjizenje : Form
    {
        public formaknjizenje()
        {
            InitializeComponent();
        }
        string[] opis;
        decimal[] zbroji;
        decimal[] zbroji2;
        decimal[] razlika;
        tim18_racunovodstvo upiti = new tim18_racunovodstvo();
        /// <summary>
        /// metoda koja se poziva iz glavnog izbornika, ona preko raznih upita čita kompletnu knjigu, dakle isplaćene akontacije, troškove, njihov
        /// obračun i razliku između akontacije i konačnih troškova
        /// </summary>
        public void citaj_knjigu() {
            SqlDataReader glavna_knjiga;
            glavna_knjiga = upiti.upisiGlavnaKnjiga2(0);

            razlika = new decimal[100];
            while (glavna_knjiga.Read())
            {
                
                int broj2 = dgvknjizenje.Rows.Add();
                dgvknjizenje.Rows[broj2].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                {
                    dgvknjizenje.Rows[broj2].Cells[1].Value = "-";
                }
                else
                {
                    dgvknjizenje.Rows[broj2].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                }
                dgvknjizenje.Rows[broj2].Cells[2].Value = "Isplaćena akontacija";
                decimal akontacija_neformat = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("akontacija")).ToString());
                dgvknjizenje.Rows[broj2].Cells[3].Value = string.Format("{0:C}", Math.Abs(akontacija_neformat));              
                dgvknjizenje.Rows[broj2].Cells[4].Value =  string.Format("{0:C}", Math.Abs(0));
                dgvknjizenje.Rows[broj2].Cells[5].Value = 1630;
                razlika[nalog] = akontacija_neformat;

                int broj3 = dgvknjizenje.Rows.Add();

                dgvknjizenje.Rows[broj3].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                {
                    dgvknjizenje.Rows[broj3].Cells[1].Value = "-";
                }
                else
                {
                    dgvknjizenje.Rows[broj3].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                }
                dgvknjizenje.Rows[broj3].Cells[2].Value = "Potraživanja od zaposlenih";
                decimal akontacija_neformat1 = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("akontacija")).ToString());
                dgvknjizenje.Rows[broj3].Cells[3].Value = string.Format("{0:C}", Math.Abs(0));
                dgvknjizenje.Rows[broj3].Cells[4].Value = string.Format("{0:C}", Math.Abs(akontacija_neformat1));
                dgvknjizenje.Rows[broj3].Cells[5].Value = 1020;

               

               

            }

            zbroji = new decimal[100];

            glavna_knjiga = upiti.upisiGlavnaKnjiga2(1);
            while (glavna_knjiga.Read())
            {

                int broj = dgvknjizenje.Rows.Add();

                dgvknjizenje.Rows[broj].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                {
                    dgvknjizenje.Rows[broj].Cells[1].Value = "-";
                }
                else
                {
                    dgvknjizenje.Rows[broj].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                }
                dgvknjizenje.Rows[broj].Cells[2].Value = "Troškovi prijevoza";
               
                decimal suma_neformat1 = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("suma")).ToString());
                dgvknjizenje.Rows[broj].Cells[3].Value = string.Format("{0:C}", Math.Abs(suma_neformat1));
                dgvknjizenje.Rows[broj].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));
                dgvknjizenje.Rows[broj].Cells[5].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("konto"));
                zbroji[nalog] += suma_neformat1;

            }

            glavna_knjiga = upiti.upisiGlavnaKnjiga2(2);
            while (glavna_knjiga.Read())
            {
                int broj = dgvknjizenje.Rows.Add();

                dgvknjizenje.Rows[broj].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                {
                    dgvknjizenje.Rows[broj].Cells[1].Value = "-";
                }
                else
                {
                    dgvknjizenje.Rows[broj].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                }
                dgvknjizenje.Rows[broj].Cells[2].Value = "Troškovi dnevnica";
                decimal suma_neformat1 = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("suma")).ToString());
                dgvknjizenje.Rows[broj].Cells[3].Value = string.Format("{0:C}", Math.Abs(suma_neformat1));
                dgvknjizenje.Rows[broj].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));
                dgvknjizenje.Rows[broj].Cells[5].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("konto"));
                zbroji[nalog] += suma_neformat1;

            }

            glavna_knjiga = upiti.upisiGlavnaKnjiga2(3);
            while (glavna_knjiga.Read())
            {
                int broj = dgvknjizenje.Rows.Add();

                dgvknjizenje.Rows[broj].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                {
                    dgvknjizenje.Rows[broj].Cells[1].Value = "-";
                }
                else
                {
                    dgvknjizenje.Rows[broj].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                }
                dgvknjizenje.Rows[broj].Cells[2].Value = "Ostali troškovi";
                decimal suma_neformat1 = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("suma")).ToString());
                dgvknjizenje.Rows[broj].Cells[3].Value = string.Format("{0:C}", Math.Abs(suma_neformat1));
                dgvknjizenje.Rows[broj].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));
                dgvknjizenje.Rows[broj].Cells[5].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("konto"));

                zbroji[nalog] += suma_neformat1;
            }

            glavna_knjiga = upiti.upisiGlavnaKnjiga2(-1);

            while (glavna_knjiga.Read())
            {
                    int broj21 = dgvknjizenje.Rows.Add();
                    dgvknjizenje.Rows[broj21].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                    int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                    if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum1")))
                    {
                        dgvknjizenje.Rows[broj21].Cells[1].Value = "-";
                    }
                    else
                    {
                        dgvknjizenje.Rows[broj21].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum1"]).ToString("dd/MM/yyyy");
                    }

                        dgvknjizenje.Rows[broj21].Cells[2].Value = "Obračun troškova";

                        dgvknjizenje.Rows[broj21].Cells[4].Value = string.Format("{0:C}", Math.Abs(zbroji[nalog]));

                        dgvknjizenje.Rows[broj21].Cells[3].Value = string.Format("{0:C}", Math.Abs(0));
                        dgvknjizenje.Rows[broj21].Cells[5].Value = 1630;
   
            }
            glavna_knjiga = upiti.upisiGlavnaKnjiga2(-1);
            while (glavna_knjiga.Read())
            {
                int broj21 = dgvknjizenje.Rows.Add();
                dgvknjizenje.Rows[broj21].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum1")))
                {
                    dgvknjizenje.Rows[broj21].Cells[1].Value = "-";
                }
                else
                {
                    dgvknjizenje.Rows[broj21].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum1"]).ToString("dd/MM/yyyy");
                }

                dgvknjizenje.Rows[broj21].Cells[2].Value = "Obračun razlike";

                if (razlika[nalog]-zbroji[nalog] > 0)
                {
                    dgvknjizenje.Rows[broj21].Cells[3].Value = string.Format("{0:C}", Math.Abs(razlika[nalog]-zbroji[nalog]));

                    dgvknjizenje.Rows[broj21].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));
                    dgvknjizenje.Rows[broj21].Cells[5].Value = 1020;
                   
                    int broj3 = dgvknjizenje.Rows.Add();

                    dgvknjizenje.Rows[broj3].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum1")))
                    {
                        dgvknjizenje.Rows[broj3].Cells[1].Value = "-";
                    }
                else
                    {
                        dgvknjizenje.Rows[broj3].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum1"]).ToString("dd/MM/yyyy");
                    }
                    dgvknjizenje.Rows[broj3].Cells[2].Value = "Obračun razlike";
                    decimal akontacija_neformat1 = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("akontacija")).ToString());
                    dgvknjizenje.Rows[broj3].Cells[3].Value = string.Format("{0:C}", Math.Abs(0));
                    dgvknjizenje.Rows[broj3].Cells[4].Value = string.Format("{0:C}", Math.Abs(razlika[nalog] - zbroji[nalog]));
                    dgvknjizenje.Rows[broj3].Cells[5].Value = 1630;
                }



                else {
                    dgvknjizenje.Rows[broj21].Cells[4].Value = string.Format("{0:C}", Math.Abs(razlika[nalog] - zbroji[nalog]));

                    dgvknjizenje.Rows[broj21].Cells[3].Value = string.Format("{0:C}", Math.Abs(0));
                    dgvknjizenje.Rows[broj21].Cells[5].Value = 1630;

                    int broj3 = dgvknjizenje.Rows.Add();

                    dgvknjizenje.Rows[broj3].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                    if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum1")))
                    {
                        dgvknjizenje.Rows[broj3].Cells[1].Value = "-";
                    }
                    else
                    {
                        dgvknjizenje.Rows[broj3].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum1"]).ToString("dd/MM/yyyy");
                    }
                    dgvknjizenje.Rows[broj3].Cells[2].Value = "Obračun razlike";
                    decimal akontacija_neformat1 = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("akontacija")).ToString());
                    dgvknjizenje.Rows[broj3].Cells[3].Value = string.Format("{0:C}", Math.Abs(0));
                    dgvknjizenje.Rows[broj3].Cells[4].Value = string.Format("{0:C}", Math.Abs(razlika[nalog] - zbroji[nalog]));
                    dgvknjizenje.Rows[broj3].Cells[5].Value = 1020;
                
                }
   
            }

        }


        /// <summary>
        /// metoda koja se poziva prilikom pojedinog obračuna naloga, pokazuje samo obračunate troškove za taj nalog
        /// </summary>
        /// <param name="troskovi">SqlDataReader varijabla koja nam daje pojedine vrste troškova za neki nalog</param>
        /// <param name="razlika">Razlika troškova i akontacije</param>
        /// <param name="id_naloga">Id naloga za koji se obračunavaju</param>
        public void proknjizi(SqlDataReader troskovi, float razlika, int id_naloga)
        {
                zbroji2 = new decimal[100];
                SqlDataReader glavna_knjiga;
                SqlDataReader vrstatroska;

                this.putniNalogTableAdapter.azuriranje(this.piDB1DataSet.putniNalog, id_naloga, 4); 
                int i = 0;
                opis = new string[3];

                while (troskovi.Read())
                {
                    opis[i] = troskovi.GetValue(troskovi.GetOrdinal("opis")).ToString();
                    i++;
                }
                bool trosak1 = false; 
                bool trosak2 = false;
                bool trosak3 = false;
                string lool = DateTime.Now.ToLongTimeString(); 
                Convert.ToDateTime(lool).ToString("dd/MM/yyyy");
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(opis[j]) == 1 && trosak1 == false)
                    {
                        trosak1 = true;



                        vrstatroska = upiti.vrsta(id_naloga, 1);

                        while (vrstatroska.Read())
                        {
                           
                            string trosak = vrstatroska.GetValue(vrstatroska.GetOrdinal("id_troska")).ToString();
                            int upis = int.Parse(trosak);
                            this.troskovi_kontoTableAdapter.knjizenje(this.piDB1DataSet.troskovi_konto, upis, 4403, System.DateTime.Parse(lool));

                        }

                        glavna_knjiga = upiti.upisiGlavnaKnjiga(id_naloga, 1);


                        while (glavna_knjiga.Read())
                        {


                            int broj = dgvknjizenje.Rows.Add();

                            dgvknjizenje.Rows[broj].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                            int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                            if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                            {
                                dgvknjizenje.Rows[broj].Cells[1].Value = "-";
                            }
                            else
                            {
                                dgvknjizenje.Rows[broj].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                            }
                            dgvknjizenje.Rows[broj].Cells[2].Value = "Troškovi prijevoza";

                            decimal suma = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("suma")).ToString());
                            dgvknjizenje.Rows[broj].Cells[3].Value = string.Format("{0:C}", Math.Abs(suma));
                            dgvknjizenje.Rows[broj].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));


                            dgvknjizenje.Rows[broj].Cells[5].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("konto"));
                            zbroji2[nalog] += suma;


                        }

                    }


                    else if (int.Parse(opis[j]) == 2 && trosak2 == false)
                    {
                        trosak2 = true;

                        vrstatroska = upiti.vrsta(id_naloga, 2);

                        while (vrstatroska.Read())
                        {
                            string trosak = vrstatroska.GetValue(vrstatroska.GetOrdinal("id_troska")).ToString();
                            int upis = int.Parse(trosak);
                            this.troskovi_kontoTableAdapter.knjizenje(this.piDB1DataSet.troskovi_konto, upis, 4403, System.DateTime.Parse(lool));

                        }








                        glavna_knjiga = upiti.upisiGlavnaKnjiga(id_naloga, 2);
                        while (glavna_knjiga.Read())
                        {
                            int broj = dgvknjizenje.Rows.Add();

                            dgvknjizenje.Rows[broj].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                            int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                            if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                            {
                                dgvknjizenje.Rows[broj].Cells[1].Value = "-";
                            }
                            else
                            {
                                dgvknjizenje.Rows[broj].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                            }
                            dgvknjizenje.Rows[broj].Cells[2].Value = "Troškovi dnevnica";
                            decimal suma = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("suma")).ToString());
                            dgvknjizenje.Rows[broj].Cells[3].Value = string.Format("{0:C}", Math.Abs(suma));
                            dgvknjizenje.Rows[broj].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));


                            dgvknjizenje.Rows[broj].Cells[5].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("konto"));

                            zbroji2[nalog] += suma;
                        }

                    }
                    else if (int.Parse(opis[j]) == 3 && trosak3 == false)
                    {
                        trosak3 = true;

                        vrstatroska = upiti.vrsta(id_naloga, 3);

                        while (vrstatroska.Read())
                        {
                            string trosak = vrstatroska.GetValue(vrstatroska.GetOrdinal("id_troska")).ToString();
                            int upis = int.Parse(trosak);
                            this.troskovi_kontoTableAdapter.knjizenje(this.piDB1DataSet.troskovi_konto, upis, 4403, System.DateTime.Parse(lool));

                        }







                        
                        glavna_knjiga = upiti.upisiGlavnaKnjiga(id_naloga, 3);
                        while (glavna_knjiga.Read())
                        {
                            int broj = dgvknjizenje.Rows.Add();

                            dgvknjizenje.Rows[broj].Cells[0].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog"));
                            int nalog = int.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("nalog")).ToString());
                            if (glavna_knjiga.IsDBNull(glavna_knjiga.GetOrdinal("datum")))
                            {
                                dgvknjizenje.Rows[broj].Cells[1].Value = "-";
                            }
                            else
                            {
                                dgvknjizenje.Rows[broj].Cells[1].Value = Convert.ToDateTime(glavna_knjiga["datum"]).ToString("dd/MM/yyyy");
                            }
                            dgvknjizenje.Rows[broj].Cells[2].Value = "Ostali troškovi";
                            decimal suma = decimal.Parse(glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("suma")).ToString());
                            dgvknjizenje.Rows[broj].Cells[3].Value = string.Format("{0:C}", Math.Abs(suma));
                            dgvknjizenje.Rows[broj].Cells[4].Value = string.Format("{0:C}", Math.Abs(0));


                            dgvknjizenje.Rows[broj].Cells[5].Value = glavna_knjiga.GetValue(glavna_knjiga.GetOrdinal("konto"));
                            zbroji2[nalog] += suma;
                        }

                    }

                    else
                    {
                        MessageBox.Show("Svi troškovi proknjiženi!");
                    }


                }
                SqlDataReader knjiga2;
                knjiga2 = upiti.upisiGlavnaKnjiga2(-1);
                while (knjiga2.Read())
                {
                    int nalog = int.Parse(knjiga2.GetValue(knjiga2.GetOrdinal("nalog")).ToString());
                    decimal ajmeeee = zbroji2[nalog];
                    if (ajmeeee != 0)
                    {
                        int broj77 = dgvknjizenje.Rows.Add();

                        dgvknjizenje.Rows[broj77].Cells[0].Value = knjiga2.GetValue(knjiga2.GetOrdinal("nalog"));

                        if (knjiga2.IsDBNull(knjiga2.GetOrdinal("datum1")))
                        {
                            dgvknjizenje.Rows[broj77].Cells[1].Value = "-";
                        }
                        else
                        {
                            dgvknjizenje.Rows[broj77].Cells[1].Value = Convert.ToDateTime(knjiga2["datum1"]).ToString("dd/MM/yyyy");
                        }
                        dgvknjizenje.Rows[broj77].Cells[2].Value = "Obračun troškova";


                        dgvknjizenje.Rows[broj77].Cells[3].Value = string.Format("{0:C}", Math.Abs(0));
                        dgvknjizenje.Rows[broj77].Cells[4].Value = string.Format("{0:C}", Math.Abs(zbroji2[nalog]));



                        dgvknjizenje.Rows[broj77].Cells[5].Value = 1020;
                    }
                }

        }
        private void formaknjizenje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.Fill(this.piDB1DataSet.putniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet.troskovi_konto' table. You can move, or remove it, as needed.
            this.troskovi_kontoTableAdapter.Fill(this.piDB1DataSet.troskovi_konto);
            // TODO: This line of code loads data into the 'piDB1DataSet.putniNalog' table. You can move, or remove it, as needed.
            this.putniNalogTableAdapter.Fill(this.piDB1DataSet.putniNalog);
            // TODO: This line of code loads data into the 'piDB1DataSet.troskovi_konto' table. You can move, or remove it, as needed.
            this.troskovi_kontoTableAdapter.Fill(this.piDB1DataSet.troskovi_konto);
            // TODO: This line of code loads data into the 'piDB1DataSet.troskovi_konto' table. You can move, or remove it, as needed.
            this.troskovi_kontoTableAdapter.Fill(this.piDB1DataSet.troskovi_konto);

        }
                
        }
    }
