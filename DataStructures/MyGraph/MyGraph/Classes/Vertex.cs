﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyGraph.Classes
{
    public class Vertex<T>
    {
        public T Data { get; set; }
        
        public Vertex(T data)
        {
            Data = data;
        }
    }
}
