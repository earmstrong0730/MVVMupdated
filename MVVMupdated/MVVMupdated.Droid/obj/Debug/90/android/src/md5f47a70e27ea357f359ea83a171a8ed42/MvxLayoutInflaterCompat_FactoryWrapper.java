package md5f47a70e27ea357f359ea83a171a8ed42;


public class MvxLayoutInflaterCompat_FactoryWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.LayoutInflater.Factory
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;:GetOnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler:Android.Views.LayoutInflater/IFactoryInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("MvvmCross.Platforms.Android.Binding.Binders.MvxLayoutInflaterCompat+FactoryWrapper, MvvmCross", MvxLayoutInflaterCompat_FactoryWrapper.class, __md_methods);
	}


	public MvxLayoutInflaterCompat_FactoryWrapper ()
	{
		super ();
		if (getClass () == MvxLayoutInflaterCompat_FactoryWrapper.class)
			mono.android.TypeManager.Activate ("MvvmCross.Platforms.Android.Binding.Binders.MvxLayoutInflaterCompat+FactoryWrapper, MvvmCross", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (java.lang.String p0, android.content.Context p1, android.util.AttributeSet p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (java.lang.String p0, android.content.Context p1, android.util.AttributeSet p2);

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
