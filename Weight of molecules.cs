using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project_2
{
    internal class Class1
    {
        static void Main()
        {
            string input, element, atomicWeight;

            string[] arrayOfElements = new string[10];
            int[] arrayOfAtomicWeights = new int[10];

            int realLen, posOfWhiteSpace, countOfInput = 1;
            int atomicWeightnum, t = 1, T;
            int indexOfElement = 0, indexOfAtomicWeight = 0;

            do
            {
                input = Console.ReadLine();
                realLen = input.Length;

                posOfWhiteSpace = input.IndexOf(' ');
                element = input.Substring(0, posOfWhiteSpace);

                arrayOfElements[indexOfElement] = element;

                for (int a = posOfWhiteSpace; a < realLen; ++a)
                {
                    char j = input[a];
                    if (j != ' ')
                    {
                        atomicWeight = input.Substring(a, realLen - (a));
                        atomicWeightnum = int.Parse(atomicWeight);
                        arrayOfAtomicWeights[indexOfAtomicWeight] = atomicWeightnum;
                        break;
                    }
                }

                ++indexOfElement; ++indexOfAtomicWeight;
            } while (++countOfInput <= 10);


            do
            {
                Locate(0, 10); EmptyLine();
                Locate(0, 10); T = int.Parse(Console.ReadLine());
            } while (!(T >= 1 && T <= 100));

            string[] arrayOfMolecules = new string[T];
            int indexOfMolecule = 0;

            do
            {
                arrayOfMolecules[indexOfMolecule] =  Console.ReadLine();
                ++indexOfMolecule;
            } while (++t <= T);

            t = 1;

            string molecule, currElement, ch, strNumCh;

            int lenOfMolecule, moleculeWeight = 0, valueOfAtomicWeight, numCh, intNumCh;
            int i, oldI, b = 0, index = 0;

            bool checkIfNum;

            while (t <= T)
            {
                molecule = arrayOfMolecules[index];
                lenOfMolecule = molecule.Length;

                for(i = 0; i < lenOfMolecule; ++i)
                {
                    ch = molecule[i].ToString();
                    
                    checkIfNum = int.TryParse(ch, out numCh);
                    strNumCh = numCh.ToString();

                    if (checkIfNum == true) 
                    {
                        oldI = i;

                        while(true)
                        {
                            ++i;

                            if (i < lenOfMolecule) ch = molecule[i].ToString();

                            checkIfNum = int.TryParse(ch, out numCh);

                            if (checkIfNum == false || i == lenOfMolecule)
                            {
                                intNumCh = int.Parse(strNumCh);

                                currElement = molecule.Substring((oldI - b), b);

                                indexOfElement = Array.IndexOf(arrayOfElements, currElement);

                                valueOfAtomicWeight = arrayOfAtomicWeights[indexOfElement];
                                
                                moleculeWeight = moleculeWeight + (valueOfAtomicWeight * intNumCh);

                                b = -1; --i;

                                break;
                            }

                            strNumCh = strNumCh + numCh;
                        } 
                    }

                    ++b;
                }

                Console.WriteLine(moleculeWeight);

                moleculeWeight = 0;
                ++index; ++t;
            }
        } 

        static void Locate(int col, int row)
        {
            Console.SetCursorPosition(col, row);
        }

        static void EmptyLine()
        {
            string line = "";
            for (int i = 1; i <= 100; ++i, line += " ") ;

            Console.WriteLine(line);
        }
    }
}