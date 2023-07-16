using System;
using System.Collections.Generic;
using System.Data.Common;

namespace School{
    public class Alumn{
        private string id;
        
        public Alumn(string name=""){
        this.Name = name;
        this.id = Guid.NewGuid().ToString();
        this.Average = 0;
        }
        public string Name { get; private set;} 
        public double Average { get; private set;} 
        public string GetId => id;

    }}