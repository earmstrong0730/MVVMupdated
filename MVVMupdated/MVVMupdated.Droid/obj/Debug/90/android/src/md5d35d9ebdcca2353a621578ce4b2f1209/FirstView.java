package md5d35d9ebdcca2353a621578ce4b2f1209;


public class FirstView
	extends md5d35d9ebdcca2353a621578ce4b2f1209.BaseView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MVVMupdated.Droid.Views.FirstView, MVVMupdated.Droid", FirstView.class, __md_methods);
	}


	public FirstView ()
	{
		super ();
		if (getClass () == FirstView.class)
			mono.android.TypeManager.Activate ("MVVMupdated.Droid.Views.FirstView, MVVMupdated.Droid", "", this, new java.lang.Object[] {  });
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