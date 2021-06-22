using System;
using System.Collections.Generic;

namespace EBAUExercise.Models
{
    /// <summary>
    /// Generc List Model Class
    /// </summary>
    public class ListModel<T>
    {
        public List<T> Items { get; set; }

        public ListModel(List<T> list)
        {
            Items = list;
        }
    }
}