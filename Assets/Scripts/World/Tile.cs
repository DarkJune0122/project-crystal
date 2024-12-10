using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Crystal
{
    public sealed class Tile : MonoBehaviour
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


    	[CustomEditor(typeof(Tile))]
    	private class Editor_Tile : Editor
    	{
    		public override void OnInspectorGUI()
    		{
    			base.OnInspectorGUI();
    			Tile obj = (Tile)target;
    		}
    	}
    #endif
    }
}