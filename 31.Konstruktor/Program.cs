﻿using _30.Class_method;
using _31.Konstruktor;
using System;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();

            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel name";

            excelFile.GenerateReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();

            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.FileName = "word-file";

            wordDocumentFile.Print();
        }
    }
}