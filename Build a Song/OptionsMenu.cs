using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

  public GameObject popDrop;
  public GameObject rockDrop;
  public GameObject electricDrop;
  public GameObject indieDrop;
  public GameObject countryDrop;

  public TMPro.TMP_Dropdown GenreDropDown;

  void Update()
  {
    if (GenreDropDown.value == 0)
    {
      print ("pop");
      PopChoosen();

    } else if (GenreDropDown.value == 1)
    {
      print ("rock");
      RockChoosen();

    } else if (GenreDropDown.value == 2)
    {
      print ("rock");
      ElectricChoosen();

    } else if (GenreDropDown.value == 3)
    {
      print ("indie");
      IndieChoosen();

    } else if (GenreDropDown.value == 4)
    {
      print ("country");
      CountryChoosen();
    }

  }

  public void PopChoosen()
  {
    popDrop.SetActive(true);
    rockDrop.SetActive(false);
    electricDrop.SetActive(false);
    indieDrop.SetActive(false);
    countryDrop.SetActive(false);
  }

  public void RockChoosen()
  {
    popDrop.SetActive(false);
    rockDrop.SetActive(true);
    electricDrop.SetActive(false);
    indieDrop.SetActive(false);
    countryDrop.SetActive(false);
  }

  public void ElectricChoosen()
  {
    popDrop.SetActive(false);
    rockDrop.SetActive(false);
    electricDrop.SetActive(true);
    indieDrop.SetActive(false);
    countryDrop.SetActive(false);
  }

  public void IndieChoosen()
  {
    popDrop.SetActive(false);
    rockDrop.SetActive(false);
    electricDrop.SetActive(false);
    indieDrop.SetActive(true);
    countryDrop.SetActive(false);
  }

  public void CountryChoosen()
  {
    popDrop.SetActive(false);
    rockDrop.SetActive(false);
    electricDrop.SetActive(false);
    indieDrop.SetActive(false);
    countryDrop.SetActive(true);
  }

}
