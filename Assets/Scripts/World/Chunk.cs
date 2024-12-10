using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Crystal
{
    public sealed class Chunk : MonoBehaviour
    {
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Public Properties
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>



    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Serialized Fields
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>



    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Private Fields
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>



    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Unity Callbacks
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>
    	private void Awake()
    	{
        
    	}

    	private void Start()
    	{
        
    	}

    	private void Update()
    	{
        
    	}
	
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Public Methods
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>
	


    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Miscellaneous
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>



    #if UNITY_EDITOR
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- <![CDATA[
    	/// 
    	///                                     Editor Methods
    	/// 
    	/// -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- ]]>
    	private void OnDrawGizmos()
    	{
        
    	}

    	private void OnDrawGizmosSelected()
    	{
        
    	}


    	[CustomEditor(typeof(Chunk))]
    	private class Editor_Chunk : Editor
    	{
    		public override void OnInspectorGUI()
    		{
    			base.OnInspectorGUI();
    			Chunk obj = (Chunk)target;
    		}
    	}
    #endif
    }
}