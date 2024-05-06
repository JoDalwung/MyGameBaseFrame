using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDialogLoader : MonoBehaviour
{    
    public List<IDialog.DialogName> Dialog_names = new List<IDialog.DialogName>();
    [HideInInspector] public List<RectTransform> DialogLayers = new List<RectTransform>();
    // 1:1 =  Loader : Dialog 
    // �ϳ��� ���������� Dialog�� ������ ����ϴ� ��찡 ������ �ִ�.
    // ������ �����ϼ��� ���ɼ��� ������ ������� 
    // DialogLayers�� Dialog_names ������ �������� ���̾� ĳ��
    // Content���� �������� ui �ε带 ����


    public void LoadDialog()
    {
        if (Dialog_names.Count > 0)
        {
            for (int i = 0; i < Dialog_names.Count; i++)
            {
                DialogLayers.Add(Instantiate(Resources.Load<RectTransform>($"Dialog/{Dialog_names[i].ToString()}")));
                DialogLayers[i].transform.SetParent(GameObject.Find("GameManager").transform.GetChild(0).GetChild(0));
            }
            AllHideDialog();
        }        
    }

    public void ShowIdxDialog(int idx = 0)
    {
        if(DialogLayers.Count > 0)
            DialogLayers[idx].gameObject.SetActive(true);
    }

    public void HideIdxDialog(int idx)
    {
        if (DialogLayers.Count > 0)
            DialogLayers[idx].gameObject.SetActive(false);
    }

    public void AllHideDialog()
    {
        for (int i=0; i < DialogLayers.Count; i++)
        {
            DialogLayers[i].gameObject.SetActive(false);
        }    
    } 


}
