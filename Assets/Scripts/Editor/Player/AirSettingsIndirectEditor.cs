using EditorExtend;
using UnityEditor;

public class AirSettingsIndirectEditor : IndirectEditor
{
    protected override string DefaultLabel => "空中设置";
    [AutoProperty]
    public SerializedProperty airTransformAccelerate, playerHeight;

    public AirSettingsIndirectEditor(SerializedProperty serializedProperty, string label = null) : base(serializedProperty, label)
    {
    }

    protected override void MyOnInspectorGUI()
    {
        airTransformAccelerate.FloatField("加速度(空中控制力)");
        playerHeight.FloatField("离地高度标准");
    }
}