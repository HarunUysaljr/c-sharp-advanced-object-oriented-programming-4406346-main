class Persons{


    public Persons(int age, int year){

        Vage = age;
        Vyear = year;

    }

    public int GetArea() => (Vage - Vyear);

    public int VageM{
        get{
            return Vage;
        }
        set{
            Vage = value;
        }
    }

    public int VyearM{
        get{return Vyear;}
        set{Vyear = value;
        }
    }



    int Vage;
    int Vyear;

}




class Calculate{


    public Calculate(int s1,int s2){

        Say1 = s1;
        Say2 = s2;
    }


    public int Hesapla() => (say1 + say2);


    public int Say1{
        get{ return say1;}
        set{say1=value;}
    }

        public int Say2{
        get{ return say2;}
        set{say2=value;}
    }


    int say1;
    int say2;
}