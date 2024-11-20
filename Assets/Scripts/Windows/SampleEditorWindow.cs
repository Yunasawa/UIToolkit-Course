using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using YNL.Editors.Extensions;

public class SampleEditorWindow : EditorWindow
{
    [MenuItem("Tools/Sample Editor Window")]
    public static void ShowWindow()
    {
        SampleEditorWindow window = new SampleEditorWindow();
        window.titleContent = new GUIContent("Sample Editor Window");

        window.Show();
    }

    private void CreateGUI()
    {
        Image image = new Image();
        image.style.backgroundColor = Color.green;
        image.style.flexGrow = 1;

        rootVisualElement.AddElements(image);
    }
}
