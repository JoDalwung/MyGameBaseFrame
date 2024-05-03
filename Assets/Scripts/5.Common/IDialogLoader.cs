using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDialogLoader : MonoBehaviour
{    
    public IDialog.DialogName Dialog;
    GameObject ContentDialog;

    // Content에서 수동으로 ui 로드를 하자

    public void LoadDialog()
    {
        ContentDialog = Instantiate(Resources.Load<GameObject>($"UI/2.GameDialog/{Dialog.ToString()}"));
        ContentDialog.transform.parent = GameObject.Find("GameManager").transform.GetChild(0).GetChild(0);
        HideDialog();
    }

    public void ShowDialog() => ContentDialog.SetActive(true);
    public void HideDialog() => ContentDialog.SetActive(false);




}
