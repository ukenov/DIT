/* UltimateRadialMenuInputManagerEditor.cs */
/* Written by Kaz Crowe */
using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;

[CustomEditor( typeof( UltimateRadialMenuInputManager ) )]
public class UltimateRadialMenuInputManagerEditor : Editor
{
	UltimateRadialMenuInputManager targ;
	bool mulitpleInputManagerError = false;
	bool worldSpaceMenus = false;

	private void OnEnable ()
	{
		mulitpleInputManagerError = FindObjectsOfType<UltimateRadialMenuInputManager>().Length > 1;

		targ = ( UltimateRadialMenuInputManager )target;

		worldSpaceMenus = false;
		UltimateRadialMenu[] allMenus = FindObjectsOfType<UltimateRadialMenu>();
		for( int i = 0; i < allMenus.Length; i++ )
		{
			if( allMenus[ i ].IsWorldSpaceRadialMenu )
			{
				worldSpaceMenus = true;
				break;
			}
		}
	}

	public override void OnInspectorGUI ()
	{
		if( !targ.gameObject.GetComponent<EventSystem>() )
		{
			EditorGUILayout.BeginVertical( "Box" );
			GUIStyle warningStyle = new GUIStyle( GUI.skin.label );
			warningStyle.normal.textColor = new Color( 1.0f, 0.0f, 0.0f, 1.0f );
			warningStyle.alignment = TextAnchor.MiddleCenter;
			EditorGUILayout.LabelField( "WARNING", warningStyle );

			GUIStyle labelStyle = new GUIStyle( GUI.skin.label ) { wordWrap = true };
			EditorGUILayout.LabelField( "The Ultimate Radial Menu Input Manager needs to be located on the EventSystem in your scene.", labelStyle );
			
			EditorGUILayout.EndVertical();
		}
		else if( mulitpleInputManagerError )
		{
			EditorGUILayout.BeginVertical( "Box" );
			GUIStyle warningStyle = new GUIStyle( GUI.skin.label );
			warningStyle.normal.textColor = new Color( 1.0f, 0.0f, 0.0f, 1.0f );
			warningStyle.alignment = TextAnchor.MiddleCenter;
			EditorGUILayout.LabelField( "WARNING", warningStyle );

			GUIStyle labelStyle = new GUIStyle( GUI.skin.label ) { wordWrap = true };
			EditorGUILayout.LabelField( "There are multiple Ultimate Radial Menu Input Managers in the scene. This is likely because of a earlier version of the Ultimate Radial Menu. Click the button below to fix this.", labelStyle );

			if( GUILayout.Button( "Fix Input Manager" ) )
			{
				UltimateRadialMenuInputManager[] allInputManagers = FindObjectsOfType<UltimateRadialMenuInputManager>();
				for( int i = 0; i < allInputManagers.Length; i++ )
				{
					if( !allInputManagers[ i ].GetComponent<EventSystem>() )
						DestroyImmediate( allInputManagers[ i ] );
				}

				if( !FindObjectOfType<EventSystem>().gameObject.GetComponent<UltimateRadialMenuInputManager>() )
					FindObjectOfType<EventSystem>().gameObject.AddComponent<UltimateRadialMenuInputManager>();

				mulitpleInputManagerError = FindObjectsOfType<UltimateRadialMenuInputManager>().Length > 1;
			}

			EditorGUILayout.EndVertical();
		}
		else
		{
			base.OnInspectorGUI();

			if( targ.customInput )
			{
				EditorGUILayout.BeginVertical( "Box" );
				GUIStyle warningStyle = new GUIStyle( GUI.skin.label );
				warningStyle.normal.textColor = new Color( 1.0f, 0.0f, 0.0f, 1.0f );
				warningStyle.alignment = TextAnchor.MiddleCenter;
				EditorGUILayout.LabelField( "WARNING", warningStyle );

				GUIStyle labelStyle = new GUIStyle( GUI.skin.label ) { wordWrap = true };
				EditorGUILayout.LabelField( "Your custom input logic should be placed inside of a different script that inherits from the UltimateRadialMenuInputManager class.", labelStyle );

				GUIStyle style = new GUIStyle( GUI.skin.label ) { richText = true, wordWrap = true };
				EditorGUILayout.LabelField( "Please check out our <b><color=blue>Video Tutorials</color></b> to learn more!", style );
				var rect = GUILayoutUtility.GetLastRect();
				EditorGUIUtility.AddCursorRect( rect, MouseCursor.Link );
				if( Event.current.type == EventType.MouseDown && rect.Contains( Event.current.mousePosition ) )
					Application.OpenURL( "https://www.youtube.com/playlist?list=PL7crd9xMJ9TltHWPVuj-GLs9ZBd4tYMmu" );

				EditorGUILayout.EndVertical();
			}
			
			if( worldSpaceMenus && targ.touchInput && targ.dynamicPositioning )
			{
				EditorGUILayout.HelpBox( "The Touch Input Dynamic Positioning will not work with world space radial menus.", MessageType.Warning );
			}
		}
	}

	private void OnSceneGUI ()
	{
		if( targ.touchInput )
		{
			UltimateRadialMenu[] allRadialMenus = FindObjectsOfType<UltimateRadialMenu>();
			for( int i = 0; i < allRadialMenus.Length; i++ )
			{
				RectTransform trans = allRadialMenus[ i ].transform.GetComponent<RectTransform>();
				Vector3 center = allRadialMenus[ i ].BasePosition;
				center.z = trans.position.z;
				Handles.DrawWireDisc( center, trans.transform.forward, ( ( trans.sizeDelta.x / 2 ) * trans.GetComponentInParent<Canvas>().GetComponent<RectTransform>().localScale.x ) * targ.activationRadius );
			}
		}
	}
}