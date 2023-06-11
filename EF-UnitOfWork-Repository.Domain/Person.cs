﻿namespace EF_UnitOfWork_Repository.Domain;
public class Person
{
 public int PersonId {
        get;
        set;
    }
    public string Name {
        get;
        set;
    }
    public int Age {
        get;
        set;
    }
    public Address Address {
        get;
        set;
    }
    public List < Email > Emails {
        get;
        set;
    }
}
