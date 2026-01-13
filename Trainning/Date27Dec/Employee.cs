using System;
using System.Collections;
namespace Date27Dec
{
    public class Employee
    {
        ArrayList myskill=null;
        public Employee()
        {
            myskill=new ArrayList();
            
            
        }
        
    public bool addSkill(Skill obj)
        {
            bool flag=false;

            if (obj != null)
            {
                flag=true;
                myskill.Add(obj);
                
            }
            return flag;
        }
    }
        
    
}