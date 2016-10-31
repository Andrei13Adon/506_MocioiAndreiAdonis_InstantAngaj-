using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LogData
/// </summary>
public class LogData
{
    int Id;
    bool Firma;

	public LogData()
	{
		
	}

    public LogData(int Id, bool Firma){
        this.Id = Id;
        this.Firma = Firma;
    }

    public int getId()
    {
        return Id;
    }

}