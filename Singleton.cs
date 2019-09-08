class Val 
{
	public int i;
}

class Singleton 
{
	private static Singleton instance;
	
	private Singleton()
    {}

	public Val val;

	public Val GetV() 
	{
		if (instance == null) 
			instance = new Singleton(); 
		instance.val.i = 42; 
		return instance;
	}
}

