using System;
using System.Collections.Generic;
using System.Data.Common;

namespace School{
    public class Evaluation{
        private string id;
        
        public Evaluation( Asignature asignature,string name=""){
        this.Name = name;
        this.id = Guid.NewGuid().ToString();
        this.Average = 0;
        this.Asignature= asignature;
        }
        public string Asignature { get; private set;} 
        public string Name { get; private set;} 
        public double Average { get; private set;} 
        public string GetId => id;

    }}