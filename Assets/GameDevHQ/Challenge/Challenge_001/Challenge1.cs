using UnityEngine;
using UnityEngine.UI;

public class Challenge1 : MonoBehaviour
{
    #region Private Variables

    [SerializeField] private int _age;
    [SerializeField] private char _gender;
    [SerializeField] private string _location;
    [SerializeField] private Text _infoText;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _age = 0;
        _gender = '-';
        _location = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _infoText.text = _age.ToString() + " " + _gender + " " + _location;
        }
    }
}
