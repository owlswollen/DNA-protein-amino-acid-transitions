using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNA___AminoAcid___Protein_Transitions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelect.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;

            }
            else if (comboBoxSelect.SelectedIndex == 1)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else if (comboBoxSelect.SelectedIndex == 2)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
        }

        private void textDNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[TAGCtagc^\b]"))
            {
                e.Handled = true;
            }
        }
        private void textAminoAcid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[FFLLSSSSYY**CC*WLLLLPPPPHHQQRRRRIIIMTTTTNNKKSSRRVVVVAAAADDEEGGGGffllssssyy**cc*wllllpppphhqqrrrriimttttnnkkssrrvvvvaaaaddeegggg^\b]"))
            {
                e.Handled = true;
            }
        }

        String nucleotides = "tcag";
        static int codonCount = 64;
        String[] codons = new String[codonCount];
        String aminoAcids = "FFLLSSSSYY**CC*WLLLLPPPPHHQQRRRRIIIMTTTTNNKKSSRRVVVVAAAADDEEGGGG";
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxDNA.KeyPress += new KeyPressEventHandler(textDNA_KeyPress);
            richTextBoxDNA2.KeyPress += new KeyPressEventHandler(textDNA_KeyPress);
            richTextBoxAminoAcid2.KeyPress += new KeyPressEventHandler(textAminoAcid_KeyPress);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        codons[i * 16 + j * 4 + k] = nucleotides[i].ToString() + nucleotides[j].ToString() + nucleotides[k].ToString();
                    }
                }
            }
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            String text = richTextBoxDNA.Text.ToLower();
            String codon;
            richTextBoxAminoAcid.Text = "";
            int groupedLength = text.Length - (text.Length % 3);
            for (int i = 0; i < groupedLength; i += 3)
            {
                codon = text[i].ToString() + text[i + 1].ToString() + text[i + 2].ToString();
                int j;
                for (j = 0; j < codonCount; j++)
                {
                    if (codon == codons[j])
                    {
                        break;
                    }
                }
                richTextBoxAminoAcid.Text += aminoAcids[j];
            }
        }

        private void buttonTransform1_Click(object sender, EventArgs e)
        {
            String text = richTextBoxDNA2.Text.ToLower();
            String codon;
            String text2 = "";
            bool found = false;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (found == false)
                {
                    if (text[i] == 'a')
                    {
                        if (text[i + 1] == 't')
                        {
                            if (text[i + 2] == 'g')
                            {
                                found = true;
                                text2 += text[i];
                            }
                        }
                    }
                }
                else
                {
                    text2 += text[i];
                }
            }

            String aminoAcidArray = "";
            int groupedLength = text2.Length - (text2.Length % 3);
            for (int i = 0; i < groupedLength; i += 3)
            {
                codon = text2[i].ToString() + text2[i + 1].ToString() + text2[i + 2].ToString();
                int j;
                for (j = 0; j < codonCount; j++)
                {
                    if (codon == codons[j])
                    {
                        break;
                    }
                }
                aminoAcidArray += aminoAcids[j];
            }

            richTextBoxProtein.Text = "";
            String protein = "";
            for (int i = 0; i < aminoAcidArray.Length; i++)
            {
                String proteinTemp = "";
                if (aminoAcidArray[i] == 'M')
                {
                    proteinTemp += aminoAcidArray[i];
                    for (int j = i + 1; j < aminoAcidArray.Length; j++)
                    {
                        proteinTemp += aminoAcidArray[j];
                        if (aminoAcidArray[j] == '*')
                        {
                            protein += proteinTemp + '\n';
                            i = j;
                            break;
                        }
                    }
                }
            }
            richTextBoxProtein.Text = protein;
        }

        private void buttonTransform2_Click(object sender, EventArgs e)
        {
            String text = richTextBoxAminoAcid2.Text;
            text = text.ToUpper();
            richTextBoxDNA1.Text = "";
            for (int i = 0; i < text.Length; i++)
            {
                int j;
                for (j = 0; j < aminoAcids.Length; j++)
                {
                    if (text[i] == aminoAcids[j])
                    { 
                        break;
                    }
                }
                richTextBoxDNA1.Text += codons[j];
            }
        }
    }
}
