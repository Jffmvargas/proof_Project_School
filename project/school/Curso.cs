using System;
using System.Collections.Generic;
using System.Data.Common;

namespace School{
    public class Curso{
        private string id;
        private string name;
        private LinkedList<Asignature> asignatures;
        private LinkedList<Alumn> alumns;

        public Curso(string name= "", string school = ""){
            id = Guid.NewGuid().ToString();
            this.NameM = name;
            this.SchoolM = school;
        }

        public LinkedList<Asignature> Asignatures{get;set;}
        public LinkedList<Alumn> Alumns{get;set;}

        public void AddLists(Object alumnOrAsignature) {
            if(alumnOrAsignature is Asignature){
                this.asignatures.AddLast((Asignature)alumnOrAsignature);
            }else{
                this.alumns.AddLast((Alumn)alumnOrAsignature);
            }
        }
        
        public string NameM{
            set{this.name = value;}
            get{return name;}
        }
        public string GetId{
            get{return id;}
        }
        public string SchoolM{
            get; set;
        }

    }
}