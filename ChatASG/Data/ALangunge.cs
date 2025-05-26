namespace ChatASG.Data
{
    public class ALangunge
    {
        public   string[] EN { set; get; }
        public   string[] AR { set; get; }
       
    }

    public class LGD
    {
        public static Dictionary<string, Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>>> Values=new Dictionary<string, Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>>>()
        {
            
           

        };

        public LGD()
        {

           
        }


        public static void Run()
        {
            Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>> En = new Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>>();

            

            Values.Add("en",En);
        }

        public static void Genrallp(Dictionary<TypeChat, Dictionary<TypeLabeLLG, string>> en)
        {

        }
    }
    public  enum TypeLabeLLG
    {

    }
   
}
