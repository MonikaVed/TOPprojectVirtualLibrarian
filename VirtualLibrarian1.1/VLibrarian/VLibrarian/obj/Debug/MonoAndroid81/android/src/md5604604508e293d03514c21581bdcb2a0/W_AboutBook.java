package md5604604508e293d03514c21581bdcb2a0;


public class W_AboutBook
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("VLibrarian.W_AboutBook, VLibrarian", W_AboutBook.class, __md_methods);
	}


	public W_AboutBook ()
	{
		super ();
		if (getClass () == W_AboutBook.class)
			mono.android.TypeManager.Activate ("VLibrarian.W_AboutBook, VLibrarian", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}