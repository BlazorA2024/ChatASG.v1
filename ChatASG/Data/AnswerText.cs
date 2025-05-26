namespace ChatASG.Data
{
    public class AnswerText
    {

        public readonly static int START = 0;
         
        public string? Body { set; get; }
        public string? TitelBody { set; get; }

        public  bool IsRtl { set; get; }

        public TypeChat TypeChat { set; get; }


     
        public static ALangunge Langunge = new ALangunge()
        {
            EN=new string[] 
            {
                "Did you mean ?",
                " Yes, you can ",

            },

          AR=new string[]
          {
            "? هل تقصد",
            "نعم  يمكن  "
          },
          
        };

        public  static string getLabelLG(bool isRtl,int index)
        {
            if (isRtl)
                return Langunge.AR[index];

            return Langunge.EN[index];
        }

        public override string ToString()
        {
            return getLabelLG(IsRtl,0) + " " +TitelBody+ ": "+Body;
        }

    }
}
