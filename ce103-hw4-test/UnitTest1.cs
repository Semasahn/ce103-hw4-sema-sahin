using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll1;
using ce103_hw4_cs_dll2;
using System.Text;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ce103_fibonacciNumber_written_test_1()
        {

            ce103csfunctions fibo = new ce103csfunctions();
            int expected = fibo.ce103_fibonacciNumber_cs(8);

            Assert.AreEqual(expected, 13);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_test_2()
        {
            ce103csfunctions fibo = new ce103csfunctions();
            int expected = fibo.ce103_fibonacciNumber_cs(23);

            Assert.AreEqual(expected, 17711);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_test_3()
        {
            ce103csfunctions fibo = new ce103csfunctions();
            int expected = fibo.ce103_fibonacciNumber_cs(32);

            Assert.AreEqual(expected, 1346269);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_1()
        {
            ce103ImportFuntions fibo = new ce103ImportFuntions();
            int expected = fibo.ce103_fibonacciNumber_cs_import(35);

            Assert.AreEqual(expected, 5702887);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_2()
        {
            ce103ImportFuntions fibo = new ce103ImportFuntions();
            int expected = fibo.ce103_fibonacciNumber_cs_import(41);

            Assert.AreEqual(expected, 102334155);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_3()
        {
            ce103ImportFuntions fibo = new ce103ImportFuntions();
            int expected = fibo.ce103_fibonacciNumber_cs_import(39);

            Assert.AreEqual(expected, 39088169);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_1()
        {
            ce103ImportFuntions importedFibo = new ce103ImportFuntions();
            ce103csfunctions writtenFibo = new ce103csfunctions();
            int written = writtenFibo.ce103_fibonacciNumber_cs(19);
            int imported = importedFibo.ce103_fibonacciNumber_cs_import(19);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_2()
        {
            ce103ImportFuntions importedFibo = new ce103ImportFuntions();
            ce103csfunctions writtenFibo = new ce103csfunctions();
            int written = writtenFibo.ce103_fibonacciNumber_cs(13);
            int imported = importedFibo.ce103_fibonacciNumber_cs_import(13);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_3()
        {
            ce103ImportFuntions importedFibo = new ce103ImportFuntions();
            ce103csfunctions writtenFibo = new ce103csfunctions();
            int written = writtenFibo.ce103_fibonacciNumber_cs(50);
            int imported = importedFibo.ce103_fibonacciNumber_cs_import(50);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strrev_written_test_1()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103csfunctions reverse = new ce103csfunctions();

            string original = "BeforeExam";
            string reversed = "maxEerofeB";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

        [TestMethod]
        public void ce103_strrev_written_test_2()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103csfunctions reverse = new ce103csfunctions();

            string original = "HelloSpace";
            string reversed = "ecapSlleH";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

        [TestMethod]
        public void ce103_strrev_written_test_3()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103csfunctions reverse = new ce103csfunctions();

            string original = "HelloDad";
            string reversed = "daDtolleH";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

    
        [TestMethod]
        public void ce103_strrev_cs_import_test_1()
        {
            ce103ImportFuntions strrev = new ce103ImportFuntions();
            Assert.AreEqual(strrev.ce103_strrev_cs_import("Printer"), "retnirP");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
             ce103csfunctions strrev = new  ce103csfunctions();
            ce103ImportFuntions Strrev = new ce103ImportFuntions();
            Assert.AreEqual(strrev.ce103_strrev_cs("Printer"), "retnirP", Strrev.ce103_strrev_cs_import("Printer"), "retnirP");
        }

        [TestMethod]
        public void ce103_strrev_cs_import_test_2()
        {
            ce103ImportFuntions strrev = new ce103ImportFuntions();
            Assert.AreEqual(strrev.ce103_strrev_cs_import("Old World"), "dlroW dlO");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
             ce103csfunctions strrev = new  ce103csfunctions();
            ce103ImportFuntions Strrev = new ce103ImportFuntions();
            Assert.AreEqual(strrev.ce103_strrev_cs("Old World"), "dlroW dlO", Strrev.ce103_strrev_cs_import("Old World"), "dlrow ldO");
        }

        [TestMethod]
        public void ce103_strrev_cs_import_test_3()
        {
            ce103ImportFuntions strrev = new ce103ImportFuntions();
            Assert.AreEqual(strrev.ce103_strrev_cs_import("HelloWorld"), "dlroWolleH");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
             ce103csfunctions strrev = new  ce103csfunctions();
            ce103ImportFuntions Strrev = new ce103ImportFuntions();
            Assert.AreEqual(strrev.ce103_strrev_cs("HelloWorld"), "dlroWolleH", Strrev.ce103_strrev_cs_import("HelloWorld"), "dlroWolleH");
        }

        [TestMethod]
        public void ce103_strlen_written_test_1()
        {
            ce103csfunctions stringLength = new ce103csfunctions();
            string text = "Software";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 8);
        }

        [TestMethod]
        public void ce103_strlen_written_test_2()
        {
            ce103csfunctions stringLength = new ce103csfunctions();
            string text = "VisualStudio2019";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 16);
        }

        [TestMethod]
        public void ce103_strlen_written_test_3()
        {
            ce103csfunctions stringLength = new ce103csfunctions();
            string text = "ExcitedText";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 11);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_1()
        {
            ce103ImportFuntions stringLength = new ce103ImportFuntions();
            string text = "Beaters";

            int expected = stringLength.ce103_strlen_cs_import(text);
            Assert.AreEqual(expected, 7);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_2()
        {
            ce103ImportFuntions stringLength = new ce103ImportFuntions();
            string text = "Origin";

            int expected = stringLength.ce103_strlen_cs_import(text);
            Assert.AreEqual(expected, 6);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_3()
        {
            ce103ImportFuntions stringLength = new ce103ImportFuntions();
            string text = "Dipping";

            int expected = stringLength.ce103_strlen_cs_import(text);
            Assert.AreEqual(expected, 7);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_1()
        {
            ce103ImportFuntions importedStrlen = new ce103ImportFuntions();
            ce103csfunctions writtenStrlen = new ce103csfunctions();
            string text = "Record";

            int imported = importedStrlen.ce103_strlen_cs_import(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_2()
        {
            ce103ImportFuntions importedStrlen = new ce103ImportFuntions();
            ce103csfunctions writtenStrlen = new ce103csfunctions();
            string text = "Blank";

            int imported = importedStrlen.ce103_strlen_cs_import(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_3()
        {
            ce103ImportFuntions importedStrlen = new ce103ImportFuntions();
            ce103csfunctions writtenStrlen = new ce103csfunctions();
            string text = "Windows";

            int imported = importedStrlen.ce103_strlen_cs_import(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strcat_written_test_1()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103csfunctions reverse = new ce103csfunctions();
            string word1 = "Hello";
            string word2 = "Everybody";

            string result = "HelloEverybody";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }

        [TestMethod]
        public void ce103_strcat_written_test_2()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103csfunctions reverse = new ce103csfunctions();
            string word1 = "Visual";
            string word2 = "Studio";

            string result = "VisualStudio";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }

        [TestMethod]
        public void ce103_strcat_written_test_3()
        {
            // we're creating object of it otherwise we cannot use ce103csfunctions class
            ce103csfunctions reverse = new ce103csfunctions();
            string word1 = "Sacred";
            string word2 = "Text";

            string result = "SacredText";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }
        [TestMethod]
        public void ce103_strcat_cs_import_test_1()
        {
            ce103ImportFuntions strcat = new ce103ImportFuntions();
            Assert.AreEqual(strcat.ce103_strcat_cs_import("Hello", "World"), "HelloWorld");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            ce103csfunctions strcat = new ce103csfunctions();
            ce103ImportFuntions Strcat = new ce103ImportFuntions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hello", "World"), "HelloWorld", Strcat.ce103_strcat_cs_import("Hello", "World"), "HelloWorld");
        }

        [TestMethod]
        public void ce103_strcat_cs_import_test_2()
        {
            ce103ImportFuntions strcat = new ce103ImportFuntions();
            Assert.AreEqual(strcat.ce103_strcat_cs_import("Computer", "Virus"), "ComputerVirus");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            ce103csfunctions strcat = new ce103csfunctions();
            ce103ImportFuntions Strcat = new ce103ImportFuntions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Computer", "Virus"), "ComputerVirus", Strcat.ce103_strcat_cs_import("Computer", "Virus"), "ComputerVirus");
        }

        [TestMethod]
        public void ce103_strcat_cs_import_test_3()
        {
            ce103ImportFuntions strcat = new ce103ImportFuntions();
            Assert.AreEqual(strcat.ce103_strcat_cs_import("Operating", "System"), "OperatingSystem");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            ce103csfunctions strcat = new ce103csfunctions();
            ce103ImportFuntions Strcat = new ce103ImportFuntions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Operating", "System"), "OperatingSystem", Strcat.ce103_strcat_cs_import("Operating", "System"), "OperatingSystem");
        }




        //[TestMethod]
        //public void ce103_strcat_written_vs_imported_test_1()
        //{
        //    // we're creating object of it otherwise we cannot use ce103csfunctions class
        //    ce103csfunctions reverse = new ce103csfunctions();
        //    ce103ImportFuntions reverse2 = new ce103ImportFuntions();
        //    string word1 = "Hi";
        //    string word2 = "There";

        //    Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), reverse2.ce103_strcat_cs_import(word1, word2));
        //}

        //[TestMethod]
        //public void ce103_strcat_written_vs_imported_test_2()
        //{
        //    // we're creating object of it otherwise we cannot use ce103csfunctions class
        //    ce103csfunctions reverse = new ce103csfunctions();
        //    ce103ImportFuntions reverse2 = new ce103ImportFuntions();
        //    string word1 = "Brave";
        //    string word2 = "Browser";

        //    Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), reverse2.ce103_strcat_cs_import(word1, word2));
        //}

        //[TestMethod]
        //public void ce103_strcat_written_vs_imported_test_3()
        //{
        //    // we're creating object of it otherwise we cannot use ce103csfunctions class
        //    ce103csfunctions reverse = new ce103csfunctions();
        //    ce103ImportFuntions reverse2 = new ce103ImportFuntions();
        //    string word1 = "Windows";
        //    string word2 = "XP";

        //    Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), reverse2.ce103_strcat_cs_import(word1, word2));
        //}
        [TestMethod]
        public void ce103_strcmp_written_test1()
        {
            ce103csfunctions strcmp = new ce103csfunctions();
            const string str1 = "hithere";
            const string str2 = "hithere";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_test2()
        {
            ce103csfunctions strcmp = new ce103csfunctions();
            const string str1 = "hi";
            const string str2 = "there";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_test3()
        {
            ce103csfunctions strcmp = new ce103csfunctions();
            const string str1 = "hello";
            const string str2 = "hello";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test1()
        {
            ce103ImportFuntions strcmp = new ce103ImportFuntions();
            const string str1 = "whatsapp";
            const string str2 = "whatsapp";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_import(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test2()
        {
            ce103ImportFuntions strcmp = new ce103ImportFuntions();
            const string str1 = "facebook";
            const string str2 = "facebook";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_import(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test3()
        {
            ce103ImportFuntions strcmp = new ce103ImportFuntions();
            const string str1 = "vmware";
            const string str2 = "virtualbox";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_import(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test1()
        {
            ce103ImportFuntions importedStrcmp = new ce103ImportFuntions();
            ce103csfunctions writtenStrcmp = new ce103csfunctions();
            const string str1 = "whatareyoudoing";
            const string str2 = "whatareyoudoing";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_import(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test2()
        {
            ce103ImportFuntions importedStrcmp = new ce103ImportFuntions();
            ce103csfunctions writtenStrcmp = new ce103csfunctions();
            const string str1 = "howitsgoing";
            const string str2 = "howitsgoing";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_import(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test3()
        {
            ce103ImportFuntions importedStrcmp = new ce103ImportFuntions();
            ce103csfunctions writtenStrcmp = new ce103csfunctions();
            const string str1 = "whatareyoudoing";
            const string str2 = "whatareyoudoing";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_import(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcpy_written_test1()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            string str1 = "Who";
            string str2 = "ami";
            string expectedStr = "ami";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }

        [TestMethod]
        public void ce103_strcpy_written_test2()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            string str1 = "Icouldntdothishomework";
            string str2 = "Fail";
            string expectedStr = "Fail";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }

        [TestMethod]
        public void ce103_strcpy_written_test3()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            string str1 = "Str";
            string str2 = "Cat";
            string expectedStr = "Cat";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }
        [TestMethod]
        public void ce103_strcpy_cs_import_test_1()
        {
            ce103ImportFuntions strcpy = new ce103ImportFuntions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_import("Computer", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            ce103ImportFuntions Strcpy = new ce103ImportFuntions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Hi"), "Hi", Strcpy.ce103_strcpy_cs_import("Computer", "Hi"), "Hi");
        }

        [TestMethod]
        public void ce103_strcpy_cs_import_test_2()
        {
            ce103ImportFuntions strcpy = new ce103ImportFuntions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_import("Computer", "Engineering"), "Engineering");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            ce103ImportFuntions Strcpy = new ce103ImportFuntions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Engineering"), "Engineering", Strcpy.ce103_strcpy_cs_import("Computer", "Engineering"), "Engineering");
        }

        [TestMethod]
        public void ce103_strcpy_cs_import_test_3()
        {
            ce103ImportFuntions strcpy = new ce103ImportFuntions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_import("Software", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            ce103ImportFuntions Strcpy = new ce103ImportFuntions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Software", "Hello"), "Hello", Strcpy.ce103_strcpy_cs_import("Software", "Hello"), "Hello");
        }
        //[TestMethod]
        //public void ce103_strcpy_imported_test1()
        //{
        //    ce103ImportFuntions strcpy = new ce103ImportFuntions();
        //    string str1 = "Imported";
        //    string str2 = "Functions";
        //    string expectedStr = "Functions";
        //    Assert.AreEqual(strcpy.ce103_strcpy_cs_import(str1, str2), expectedStr);
        //}

        //[TestMethod]
        //public void ce103_strcpy_imported_test2()
        //{
        //    ce103ImportFuntions strcpy = new ce103ImportFuntions();
        //    string str1 = "Test";
        //    string str2 = "Method";
        //    string expectedStr = "Method";
        //    Assert.AreEqual(strcpy.ce103_strcpy_cs_import(str1, str2), expectedStr);
        //}

        //[TestMethod]
        //public void ce103_strcpy_imported_test3()
        //{
        //    ce103ImportFuntions strcpy = new ce103ImportFuntions();
        //    string str1 = "String";
        //    string str2 = "Copy";
        //    string expectedStr = "Copy";
        //    Assert.AreEqual(strcpy.ce103_strcpy_cs_import(str1, str2), expectedStr);
        //}

        //[TestMethod]
        //public void ce103_strcpy_written_vs_imported_test1()
        //{
        //    ce103ImportFuntions strcpy = new ce103ImportFuntions();
        //    ce103csfunctions strcpy2 = new ce103csfunctions();
        //    string str1 = "hi";
        //    string str2 = "there";
        //    Assert.AreEqual(strcpy.ce103_strcpy_cs_import(str1, str2), strcpy2.ce103_strcpy_cs(str1, str2));
        //}

        //[TestMethod]
        //public void ce103_strcpy_written_vs_imported_test2()
        //{
        //    ce103ImportFuntions strcpy = new ce103ImportFuntions();
        //    ce103csfunctions strcpy2 = new ce103csfunctions();
        //    string str1 = "P";
        //    string str2 = "Invoke";
        //    Assert.AreEqual(strcpy.ce103_strcpy_cs_import(str1, str2), strcpy2.ce103_strcpy_cs(str1, str2));
        //}

        //[TestMethod]
        //public void ce103_strcpy_written_vs_imported_test3()
        //{
        //    ce103ImportFuntions strcpy = new ce103ImportFuntions();
        //    ce103csfunctions strcpy2 = new ce103csfunctions();
        //    string str1 = "Marshal";
        //    string str2 = "Attribute";
        //    Assert.AreEqual(strcpy.ce103_strcpy_cs_import(str1, str2), strcpy2.ce103_strcpy_cs(str1, str2));
        //}

        [TestMethod]
        public void ce103_hex2bin_written_test1()
        {
            ce103csfunctions hex2bin = new ce103csfunctions();
            string hexstring = "1313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_test2()
        {
            ce103csfunctions hex2bin = new ce103csfunctions();
            string hexstring = "1111111111111111";
            byte[] expectedArr = { 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_test3()
        {
            ce103csfunctions hex2bin = new ce103csfunctions();
            string hexstring = "FAFAFAFAFAFAFAFA";
            byte[] expectedArr = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            ce103ImportFuntions hex2bin = new ce103ImportFuntions();
            string hexstring = "AAFBCD234324";
            byte[] expectedArr = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            ce103ImportFuntions hex2bin = new ce103ImportFuntions();
            string hexstring = "2348975982379872239487";
            byte[] expectedArr = { 0x23, 0x48, 0x97, 0x59, 0x82, 0x37, 0x98, 0x72, 0x23, 0x94, 0x87 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            ce103ImportFuntions hex2bin = new ce103ImportFuntions();
            string hexstring = "1313131313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test1()
        {
            ce103ImportFuntions imported = new ce103ImportFuntions();
            ce103csfunctions written = new ce103csfunctions();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test2()
        {
            ce103ImportFuntions imported = new ce103ImportFuntions();
            ce103csfunctions written = new ce103csfunctions();
            string hexstring = "ABCDEAEC";
            byte[] expectedArr = { 0xAB, 0xCD, 0xEA, 0xEC };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test3()
        {
            ce103ImportFuntions imported = new ce103ImportFuntions();
            ce103csfunctions written = new ce103csfunctions();
            string hexstring = "91423FC23A234832FA";
            byte[] expectedArr = { 0x91, 0x42, 0x3F, 0xC2, 0x3A, 0x23, 0x48, 0x32, 0xFA };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test1()
        {
            ce103csfunctions written = new ce103csfunctions();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test2()
        {
            ce103csfunctions written = new ce103csfunctions();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test3()
        {
            ce103csfunctions written = new ce103csfunctions();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            ce103ImportFuntions imported = new ce103ImportFuntions();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            ce103ImportFuntions imported = new ce103ImportFuntions();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            ce103ImportFuntions imported = new ce103ImportFuntions();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test1()
        {
            ce103csfunctions written = new ce103csfunctions();
            ce103ImportFuntions imported = new ce103ImportFuntions();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test2()
        {
            ce103csfunctions written = new ce103csfunctions();
            ce103ImportFuntions imported = new ce103ImportFuntions();
            byte[] bin = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test3()
        {
            ce103csfunctions written = new ce103csfunctions();
            ce103ImportFuntions imported = new ce103ImportFuntions();
            byte[] bin = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
    }
}
