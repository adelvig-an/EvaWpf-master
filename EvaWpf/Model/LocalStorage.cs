﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    public static class LocalStorage
    {
        public static IEnumerable<string> TypeCosts => 
            new string[] 
            { 
                "Рыночная стоимость", 
                "Инвестиционная стоимость", 
                "Ликвидационная стоимость", 
                "Кадастровая стоимость" 
            }; 
        public static IEnumerable<string> Appraisers => 
            new string[] 
            { 
                "Дельвиг Антон Денисович", 
                "Рошка Андрей Ильевич",
                "Шестаков Денис Александрович"
            };
        
        public static IEnumerable<string> FormOrganizations =>
            new string[]
            {
                "ООО",
                "ПАО",
                "АО",
                "ИП"
            };
        public static IEnumerable<string> TypeDocsPos =>
            new string[]
            {
                "Устав",
                "Доверенность",
                "Закон"
            };
        public static IEnumerable<string> TypeDocs =>
            new string[]
            {
                "Паспорт",
                "Загранпаспорт",
                "Военный билет",
                "Временное удостоверение личности",
                "Свидетельство о рождении",
                "Служебное удостоверение работника прокуратуры",
                "Персональная электронная карта"
            };
        public static IEnumerable<string> TehDocuments =>
            new string[]
            {
                "Выписка из ЕГРН",
                "Свидетельство о государственной регистрации права",
                "Технический паспорт",
                "Кадастровый паспорт",
                "Поэтажный план",
                "Экспликация",
                "Иное"
            };
    }
}
