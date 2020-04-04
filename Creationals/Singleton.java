package patterns.creationals.singleton;

public class Singleton{

    private Singleton INSTANCE;
    private volatile Singleton VOLATILE_INSTANCE;
    private Singleton EAGERLY_INSTANCE = new Singleton();

    private Singleton(){}

    //Simple implementation. No Thread Safe
    public static Singleton getInstance(){
        if(this.INSTANCE == null){
            this.INSTANCE = new Singleton();
        }
        return this.INSTANCE;
    }

    //Synchronized implementation. Thread Safe
    public static synchronized Singleton getInstance(){
        if(this.INSTANCE == null){
            this.INSTANCE = new Singleton();
        }
        return this.INSTANCE;
    }

    //Double checked method to reduce the slow syncronized implementation.
    public static Singleton getInstance(){
        if(this.VOLATILE_INSTANCE == null){
            synchronized(Singleton.class){
                if(this.VOLATILE_INSTANCE == null){
                    this.VOLATILE_INSTANCE = new Singleton();
                }
            }
        }
        return this.VOLATILE_INSTANCE;
    }

    //Thread Safe Eagerly Implementation. No memory safe care taken.
    public static Singleton getInstance(){
        return this.EAGERLY_INSTANCE;
    }

}

