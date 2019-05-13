using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Programming_Project_3
{
    public partial class CST117ProgrammingProject3 : Form
    {

        Stream myStream;
        StreamWriter outputFile;
        String textFile;
        String textSaveFile;
        String textLower;
        String firstWordAlphabetically;
        String lastWordAlphabetically;
        String textAlphabetically;
        String textLongestWord;
        String textMostVowels;
        bool openConfirm;
        bool saveConfirm;
        String confirmMessage;

        public CST117ProgrammingProject3()
        {
            InitializeComponent();
        }

        private void CST117ProgrammingProject3_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindFromUI()
        { // get values from UI and store in variables
            
        }

        private void BindToUI()
        {// refresh UI using values stored in variables
            lblLowerCase.Text = textLower;
            lblAlphabetically.Text = textAlphabetically;
            lblLongestWord.Text = textLongestWord;
            lblMostVowels.Text = textMostVowels;
            lblConfirmText.Text = confirmMessage;
        }

        private void ResetUIValues()
        {
            myStream = null;
            textFile = "";
            textSaveFile = "";
            textLower = "";
            firstWordAlphabetically = "";
            lastWordAlphabetically = "";
            textAlphabetically = "";
            textLongestWord = "";
            textMostVowels = "";
            openConfirm = false;
            saveConfirm = false;
            confirmMessage = "";
        }

        private void FormatUIValues()
        {
            textLower = "Text converted to lower-case: " + textLower;
            textAlphabetically = "The first word alphabetically is: " + firstWordAlphabetically
                                + "\nThe last word alphabetically is: " + lastWordAlphabetically;
            textLongestWord = "The longest word is: " + textLongestWord;
            textMostVowels = "The word with the most vowels is: " + textMostVowels;
        }


        private void ReadFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            openFile.InitialDirectory = "C:\\Documents";
            textFile = openFile.FileName;
            textLower = File.ReadAllText(textFile).ToLower();
        }

        private void SaveFile()
        {
            saveFile.ShowDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
             outputFile = File.CreateText(saveFile.FileName);
                textSaveFile = saveFile.FileName;
                saveConfirm = true;
            }
            confirmMessage = "The Text File " + textFile + " was successfully opened: " + openConfirm
                            + "\nThe Text File " + textSaveFile + " was successfully saved: " + saveConfirm;
        }

        private void OpenFileAndSort()
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openConfirm = true;

                    if ((myStream = openFile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //use an array to sort each word and check them.
                            string[] word = textLower.Split(' ');

                            //loop to analyze the current word within the array
                            for (int i = 0; i < word.Length; i++)
                            {

                                /* sort to find first and last word alphabetically */
                                //Compare the String in the current word to the current first word alphabetically.
                                if (firstWordAlphabetically == "")
                                {
                                    firstWordAlphabetically = word[i];
                                }
                                else if (word[i].CompareTo(firstWordAlphabetically) < 0)
                                {
                                    firstWordAlphabetically = word[i];
                                }

                                //Same for last but in reverse in the else if.
                                if (lastWordAlphabetically == "")
                                {
                                    lastWordAlphabetically = word[i];
                                }
                                else if (word[i].CompareTo(lastWordAlphabetically) > 0)
                                {
                                    lastWordAlphabetically = word[i];
                                }

                                /* Sort to find longest word */
                                if (textLongestWord == "")
                                {
                                    textLongestWord = word[i];
                                }
                                else if (textLongestWord.Length < word[i].Length)
                                {
                                    textLongestWord = word[i];
                                }

                                /* Sort to find word with the most vowels */
                                //Create two integer values for the vowels within just this equation as they will not be used outside of this.
                                int currentVowelCount = 0;
                                int mostVowelCount = 0;
                                //Character array for searching for vowels.
                                char[] wordToChar;
                                wordToChar = word[i].ToCharArray();

                                //find any vowels within the word and count them
                                for (int j = 0; j < wordToChar.Length; j++)
                                {
                                    if (wordToChar[j] == 'a' ||
                                    wordToChar[j] == 'e' ||
                                    wordToChar[j] == 'i' ||
                                    wordToChar[j] == 'o' ||
                                    wordToChar[j] == 'u')
                                    {
                                        currentVowelCount++;
                                    }
                                }

                                //Once counted compare current vowel count to most vowel count
                                if (currentVowelCount > mostVowelCount)
                                {
                                    mostVowelCount = currentVowelCount;
                                    textMostVowels = word[i];
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            BindFromUI();
            ReadFile();
            OpenFileAndSort();
            FormatUIValues();
            SaveFile();
            BindToUI();
        }
    }
}
