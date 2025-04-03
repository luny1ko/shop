using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class ВсеТовары
    {
        public static List<Товар> ПолучитьВсеТовары()
        {
            List<Товар> list = new List<Товар>();

            list.Add(
                new Товар()
                {
                    Код = "001", 
                    Наименование = "ОС Windows 8", 
                    Количество = 10, 
                    Цена = 40.99f,
                    Описание = "Совеременная операционная система. Версия 8"
                });
            list.Add(
                new Товар()
                {
                    Код = "002",
                    Наименование = "3D Max",
                    Количество = 2,
                    Цена = 500.99f,
                    Описание = "Система визуализации и рендеринга от Autodesk Corp."
                });
            list.Add(
                new Товар()
                {
                    Код = "003",
                    Наименование = "Total Commander 1.00",
                    Количество = 100,
                    Цена = 0.5f,
                    Описание = " - "
                });
            list.Add(
                new Товар()
                {
                    Код = "004-001",
                    Наименование = "MS SQL Server",
                    Количество = 5,
                    Цена = 150.0f,
                    Описание = "СУБД от Microsoft Corp."
                });
            return list;
        }

        public static void СохранитьВсеТовары(List<Товар> товары)
        {

        }
    }
}
