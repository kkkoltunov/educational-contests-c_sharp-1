using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    public string SchoolNumber { get; set; }
    public string Address { get; }
    public List<Pupil> Pupils { get; }

    public bool WasUnited { get; set; }

    public bool WasClosed { get; set; }

    public School(string address, string schoolNumber, List<Pupil> pupils)
    {
        Address = address;
        SchoolNumber = schoolNumber;
        Pupils = pupils;
    }

    public School() { }
}