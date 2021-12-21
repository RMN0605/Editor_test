using UnityEngine;
using UnityEditor;


public class Test : EditorWindow
{
    /// <summary>テキストボックスの編集用文字列</summary>
    private string textBox1 = string.Empty;

    /// <summary>ラベル用文字列</summary>
    private string label2 = "ラベル2";
    private string label3 = "ラベル3";


    /// <summary>テキストエリアの編集用文字列 ←（宣言部）</summary>
    private string textArea = string.Empty;


    //------------------------------------------------------------------
    //ポップアップ表示に使うよ
    private int popupSelectIndex;
    //------------------------------------------------------------------


    [MenuItem("Editor/テストツール")]
    private static void Create()
    {
        GetWindow<Test>("テストウィンドウ");
    }

    private void OnGUI()
    {

        // ラベル
        GUILayout.Label("１行のみ書けるラベル");
        // テキストボックス
        textBox1 = GUILayout.TextField(textBox1);

        // ラベル
        GUILayout.Label("複数行書けるラベル");
        // テキストエリア
        textArea = GUILayout.TextArea(textArea);


        using (new GUILayout.HorizontalScope())
        {
            // ボタン
            if (GUILayout.Button("テストボタン1"))
            {
                label2 = textBox1;
            }
            // ボタン
            if (GUILayout.Button("テストボタン2"))
            {
                label3 = textArea;
            }
        }

            // ラベル
            GUILayout.Label(label2);
            // ラベル
            GUILayout.Label(label3);

        using (new GUILayout.HorizontalScope())
        {
            // ラベル
            GUILayout.Label("選択肢１");
            // ラベル
            GUILayout.Label("選択肢２");
        }

        using (new GUILayout.HorizontalScope())
        {
            // ポップアップ１
            string[] items1 = new string[] { "〇", "△", "◇", "✕" };
            popupSelectIndex = EditorGUILayout.Popup(popupSelectIndex, items1);
            // ポップアップ２
            string[] items2 = new string[] { "♢", "♧", "♡", "♤" };
            popupSelectIndex = EditorGUILayout.Popup(popupSelectIndex, items2);
        }
    }

//------------------------------------------------------------------

    #region エディタ拡張の作り方
    //------------------------------------------------------------------

    #region エディタの作り方について
    /*
        [MenuItem("Editor/テストツール")]     とかくとUnity上部に「Editor」 < 「テストツール」　が追加され使えるようになる

        private static void Create()
        {
            GetWindow<Test>("テストウィンドウ");    と書くとウィンドウ名が（テストウィンドウ）のウィンドウが生成される
        }
    */
    #endregion

    //------------------------------------------------------------------

    #region テキストボックスについて
    /*
        ・private string (テキストボックス名１) = string.Empty;   でテキストボックスの編集用文字列を生成

        ・(テキストボックス名１) = GUILayout.TextField(テキストボックス名１); で文字を書けるばしょを生成、その後（テキストボックス名１）に格納

        ・(ラベル名１) = (テキストボックス名１);     表示する際はラベルにテキストボックスの内容を格納しておこう

    */
    #endregion

    //------------------------------------------------------------------

    #region ラベルについて
    /*
        ・private string ("ラベル名１"); でラベル用文字列を生成
            private string ("ラベル名１") = "ラベル2";  と書くと最初にラベル２と表示することができる

        ・GUILayout.Label(ラベル名１);    で（ラベル名１）に格納されているものを表示する

        ・GUILayout.Label("文字"); で（文字）　が表示される
    */
    #endregion

    //------------------------------------------------------------------

    #region ポップアップについて
    /*
        ・string[] items1 = new string[] { "選択肢１", "選択肢２", "選択肢３", "選択肢４" };  この二つを書くことで選択肢のポップアップをできる

        ・popupSelectIndex = EditorGUILayout.Popup(popupSelectIndex, items1);
            popupSelectIndexをつけるようにするために、   private int popupSelectIndex;   を忘れずに記述するように
    */
    #endregion

    //------------------------------------------------------------------

    #region 水平方向に等分で配置について
    /*
        using (new GUILayout.HorizontalScope())     ｛｝内にあるものをすべて均等配置してくれる
        {
        }
    */
    #endregion

    //------------------------------------------------------------------
    #endregion

//------------------------------------------------------------------
}

