namespace alvaro.Documentos.Patterns.Patterns.Creationals
{
    public class Singleton
    {
        private Singleton oSingletonInstance;
        //Shared memory
        private volatile Singleton oSingletonSynchronizedInstance;
        //Eagerly way
        private Singleton oEagerlySingleton = new Singleton();

        private Singleton();

        //Simple implementation whithout thread safe care taken.
        public static Singleton GetSingletonInstance()
        {
            if(oSingletonInstance == null){
                oSingletonInstance = new Singleton();
            }
            return this.oSingletonInstance;
        }

        //Simple synchronized methods without performance care
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetSynchronizedSingletonInstance()
        {
            if(oSingletonSynchronizedInstance == null){
                oSingletonSynchronizedInstance = new Singleton();
            }
            return this.oSingletonSynchronizedInstance;
        }

        //Double check implementation whith thread safe and performance care taken.
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

        //Eagerly Inicialization. It is charged on memory from the start of the program
        public static Singleton GetEagerlySingleton(){
            return this.oEagerlySingleton;
        }
    }
}