using System;
using System.Collections.Generic;
using System.Data.Common;

namespace School{
    public class Asignature{

        private string id;
     
        public Asignature(string name="", string description=""){
            this.Name = name;
            this.Description = description;
            id = Guid.NewGuid().ToString();
            
        }

        public LinkedList<Evaluation> Evaluations{get;set;}

        public LinkedList<Curso> Cursos{get;set;}
        public void AddCursos(Curso curso) {
            this.Cursos.AddLast(curso);
        }

        public string Name { get; private set;}
        public string Description { get; private set;}  
        
        public string GetId => id;

        public static implicit operator string(Asignature v)
        {
            throw new NotImplementedException();
        }
    }
}