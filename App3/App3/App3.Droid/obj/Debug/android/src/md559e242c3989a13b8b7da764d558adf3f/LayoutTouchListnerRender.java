package md559e242c3989a13b8b7da764d558adf3f;


public class LayoutTouchListnerRender
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.ViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dispatchTouchEvent:(Landroid/view/MotionEvent;)Z:GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onAnimationEnd:()V:GetOnAnimationEndHandler\n" +
			"";
		mono.android.Runtime.register ("App3.Droid.Renders.LayoutTouchListnerRender, App3.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LayoutTouchListnerRender.class, __md_methods);
	}


	public LayoutTouchListnerRender (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == LayoutTouchListnerRender.class)
			mono.android.TypeManager.Activate ("App3.Droid.Renders.LayoutTouchListnerRender, App3.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public LayoutTouchListnerRender (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == LayoutTouchListnerRender.class)
			mono.android.TypeManager.Activate ("App3.Droid.Renders.LayoutTouchListnerRender, App3.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public LayoutTouchListnerRender (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == LayoutTouchListnerRender.class)
			mono.android.TypeManager.Activate ("App3.Droid.Renders.LayoutTouchListnerRender, App3.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public boolean dispatchTouchEvent (android.view.MotionEvent p0)
	{
		return n_dispatchTouchEvent (p0);
	}

	private native boolean n_dispatchTouchEvent (android.view.MotionEvent p0);


	public void onAnimationEnd ()
	{
		n_onAnimationEnd ();
	}

	private native void n_onAnimationEnd ();

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
