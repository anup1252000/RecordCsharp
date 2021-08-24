C# 9 introduces records, a new reference type that you can create instead of classes or structs. Records are distinct from classes in that record types use value-based equality. 

Internally record gets converted to class with Inequitable<T> and it use a method called decode to convert the value back to the expected values. 

In my above code, I have created a record with the name as Employee. 
public record Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; init; }

        public string State { get; set; }
    }

The IL of Employee looks like this
.class public auto ansi beforefieldinit CSharpNewfeatures.Employee
       extends [System.Runtime]System.Object
       implements class [System.Runtime]System.IEquatable`1<class CSharpNewfeatures.Employee>
{
} // end of class CSharpNewfeatures.Employee

Similar the record with Parameter  looks like this
 public abstract record Order(int id, string orderDetails)
    {
        protected abstract string GetData(int value);
    }

The class level details of the Order class remains intact as Employee; however, The IL code of parameters such as id and orderdetails are set to init for the setter. 
.field private initonly string '<orderDetails>k__BackingField'

rdCsharp
