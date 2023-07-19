using System;
using System.Collections.Generic;
using System.Data.Common;

namespace School{
    public class Curso{
        private string id;
        private string name;
       

        public Curso(string name= "", string school = ""){
            id = Guid.NewGuid().ToString();
            this.NameM = name;
            this.SchoolM = school;
        }

        public LinkedList<Asignature> Asignatures{get;set;}
        public LinkedList<Alumn> Alumns{get;set;}

        public void AddLists(Object alumnOrAsignature) {
            if(alumnOrAsignature is Asignature){
                this.Asignatures.AddLast((Asignature)alumnOrAsignature);
            }else if (alumnOrAsignature is Alumn){
                this.Alumns.AddLast((Alumn)alumnOrAsignature);
            }else{
                throw new Exception("Not is alumn or Asignature, \nfirts create Asignature or Alumn");
            }
        }

        public double GenereteAverege(string id){
            double div = 0;
            double dividendo =0;
            foreach(Asignature asignatura in Asignatures){
                dividendo += asignatura.Search(id);   
                div ++;
            }
            double result = div == 0 ? 0:dividendo/div;
            return result;

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