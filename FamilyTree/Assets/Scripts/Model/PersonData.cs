using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonData
{
    #region Личная информация
    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    /// <summary>
    /// Девечья фамилия (должно скрываться у мужчин)
    /// </summary>
    public string FirstSurname { get; set; }
    /// <summary>
    /// 0 - не известно, 1 - мужской, 2 - женский
    /// </summary>
    public int Gender { get; }
    #endregion
    #region Связи
    public int FatherID { get; set; }
    public int MotherID { get; set; }
    public List<int> BrothersAndSistersIDs { get; set; }
    public List<int> ChildrensIDs { get; set; }
    #endregion
}
