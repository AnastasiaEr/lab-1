﻿namespace Events
{
    /// <summary>
    /// Класс должен описывать представление о товаре. 
    /// В рамках лабораторной работы должен являться 
    /// источником события
    /// </summary>
    class Product
    {

        #region Variables
        /// <summary>
        /// Наименование
        /// </summary>
        private string name;
        /// <summary>
        /// Стоимость
        /// </summary>
        private decimal price;

        #endregion

        #region Properties

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                /* 
                 * TODO #5 Инициировать уведомление об 
                 * изменении наименования
                 */
            }
        }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                /*
                 * TODO #6 Инициировать уведомление об 
                 * изменении стоимости
                 */
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #4 Добавить определение событий
         */

        #endregion

        internal ProductEventArgs ProductEventArgs
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
