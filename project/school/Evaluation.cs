using System;
using System.Collections.Generic;
using System.Data.Common;

namespace School{
    public class Evaluation{
        private string id;
        
        public Evaluation( Asignature asignature, string id = "",string name=""){
        this.Name = name;
        this.id = Guid.NewGuid().ToString();
        this.Note = 0.0;
        this.Asignature= asignature;
        this.id = id;
        }
        
        public Asignature Asignature { get; private set;} 
        public string Name { get; private set;} 
        public double Note { get; private set;} 
        public string GetId => id;

    }}