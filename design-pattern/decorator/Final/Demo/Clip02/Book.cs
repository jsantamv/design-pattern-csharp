﻿using Demo.Common;

namespace Demo.Clip02
{
    class Book
    {
        public string Title { get; }
        public virtual Size Dimensions { get; }

        public Book(string title, Size dimensions)
        {
            this.Title = title;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Se crea un nuevo constructor para recbir por parametro
        /// otra instancia de book y poder armar otro libro con ;
        /// la misma estructura. 
        /// </summary>
        /// <param name="other"></param>
        protected Book(Book other) : this(other.Title, other.Dimensions)
        {
        }

        public override string ToString() =>
            $"{this.Title} - {this.Dimensions}";
    }
}
