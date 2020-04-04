namespace alvaro.Documentos.Patterns.Patterns.Creationals
{
    public class Singleton
    {
        private Singleton oSingletonInstance;
        private volatile Singleton oSingletonSynchronizedInstance;

        private Singleton();

        //Simple implementation whithout tread safe care taken.
        public static Singleton GetSingletonInstance()
        {
            if(oSingletonInstance == null){
                oSingletonInstance = new Singleton();
            }
            return this.oSingletonInstance;
        }

        //Simple synchrinized methods without performance care
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetSynchronizedSingletonInstance()
        {
            if(oSingletonSynchronizedInstance == null){
                oSingletonSynchronizedInstance = new Singleton();
            }
            return this.oSingletonSynchronizedInstance;
        }

        //Double check implementation whith tread safe care and performance taken.
        public static Singleton GetSingletonInstance()
        {
            if(oSingletonInstance == null)
            {
                lock (this)
                {
                    if(oSingletonInstance == null)
                    {
                        oSingletonInstance = new Singleton();
                    } 
                }
            }
            return this.oSingletonInstance;
        }
    }
}