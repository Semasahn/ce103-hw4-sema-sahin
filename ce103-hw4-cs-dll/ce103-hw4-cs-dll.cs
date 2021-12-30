using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll1
{
    public class ce103csfunctions
    {

        public int ce103_fibonacciNumber_cs(int fiIndex)
        {
            int first = 0, second = 1, third = 0;
            // I assigned the number 0 to the first, the number one to the second,and the number 0 to the third 

            for (int w = 2; w < fiIndex; w++)
            {

                third = first + second;
                //I added the first number and the second number and equalized the third number
                first = second;
                //I made the first number equal to the second number
                second = third;
                //  I made the second number equal to the third number
            }

            return third;
        }
       

        public string ce103_strrev_cs(string stringInput)
        {
            // Reverse using While loop  
            string reverse_string = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reverse_string = reverse_string + stringInput[length];
                length--;
            }
            return reverse_string;

        }

        public int ce103_strlen_cs(string fiStr)
        {
            int f = 0;

            while (f != fiStr.Length)
            {
                f++;
            }

            return f;
        }

        public string ce103_strcat_cs(string fiDest, string fiSrc)
        {
            string c = string.Empty;
            int s, k, T1, T2;
            T1 = fiDest.Length;
            T2 = fiSrc.Length;
            for (s = 0; s < T1; s++)
            {
                c = c + fiDest[i];
            }
            for (k = 0; k < T2; k++)
            {
                c = c + fiSrc[k];
            }
            return c;
        }

        public int ce103_strcmp_cs(string fiLhs, string fiRhs)
        {
            int str1 = 0, str2 = 0;
            for (int i = 0; i < (fiLhs.Length > fiRhs.Length ? fiLhs.Length : fiRhs.Length); i++)
            {
                str1 += (i >= fiLhs.Length ? 0 : fiLhs[i]) - (i >= fiRhs.Length ? 0 : fiRhs[i]);
                if (str2 < 0)
                {
                    if (str1 < 0)
                        str2 += str1;
                    if (str1 > 0)
                        str2 += -str1;
                }
                else
                {
                    str2 += str1;
                }
            }
            return str2;
        }

        public string ce103_strcpy_cs(string foDestination, string fiSource)
        {
            // declare and initialize destination array
            char[] destArr = new char[fiSource.Length];

            // convert source string to char array
            char[] srcArr = fiSource.ToCharArray();

            // copy string to other
            for (int h = 0; h < fiSource.Length; h++)
            {
                destArr[h] = srcArr[h];
            }

            // transfer string to temp string
            string tempDest = new string(destArr);

            // change foDestination string
            foDestination = tempDest;

            return foDestination;
        }

        public void ce103_hex2bin_cs(string fiHex, int fiHexLen, byte[] foBin)
        {
            //char[] foBinArr = new char[fiHexLen / 2];

            int[] count = { 0, 0 };  // count array for storing ascii and hex value of selected element 
            for (int i = 0; i < fiHexLen; i += 2)
            {  // array for assigning foBin elements
                char[] temp = new char[2];  // store two character from fiHex func
                int hexint = 0;  // hexint stores sum of two ascii values generated from hex base
                for (int j = 0; j < 2; j++)
                {  // for loop for calculating sum of ascii values
                    temp[j] = (char)fiHex[i + j];  // assigning first fiHex element to temp
                    if (j == 0)
                    {  // if j == 0 meaning first element of temp
                       // if and else if code snippet is taken from below website and fixed
                       // https://nachtimwald.com/2017/09/24/hex-encode-and-decode-in-c/
                        if (temp[j] >= '0' && temp[j] <= '9')
                        {  // bounds
                            count[j] = temp[j] - '0';  // find int value of nibble
                            count[j] *= 16;  // multiply by 16 because of 16^1*hex digit
                        }
                        else if (temp[j] >= 'A' && temp[j] <= 'F')
                        {  // bounds
                            count[j] = temp[j] - 'A' + 10;  // take difference between temp and 'A' then plus 10
                            count[j] *= 16;
                        }
                    }
                    else
                    {  // means 1
                        if (temp[j] >= '0' && temp[j] <= '9')
                        {
                            count[j] = temp[j] - '0';  // we're not multiplying by 16 because it's 16^0 digit
                        }
                        else if (temp[j] >= 'A' && temp[j] <= 'F')
                        {
                            count[j] = temp[j] - 'A' + 10;
                        }
                    }
                    hexint += count[j];  // get two digit value's sum and assign it to hexint
                }
                foBin[i / 2] = (byte)hexint;  // assigning summed values to foBin
            }
        }

        public void ce103_bin2hex_cs(byte[] fiBin, int fiBinLen, char[] foHex)
        {
            //char[] foHexArr = new char[fiBinLen * 2];
            //foHexArr = foHex.ToCharArray();
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            // below code snippet is taken from
            // https://nachtimwald.com/2017/09/24/hex-encode-and-decode-in-c/
            // basically this for loop gets hex number's right or left nibble and finds which character is this
            for (int m = 0; m < fiBinLen; m++)
            {
                foHex[m * 2] = arr[fiBin[m] >> 4];  // it means divide by 16. arr[fiBin[m] / 16] is true also
                foHex[m * 2 + 1] = arr[fiBin[m] & 0x0F];  // if m = 0 then fiBin[0] & 0x0f Note: fiBin[0] = 0x13
                                                          // 0001 0011 & 0000 1111 = 3 basically it means
                                                          // get hexnumber's second 
            } 
            }         
    }
}
