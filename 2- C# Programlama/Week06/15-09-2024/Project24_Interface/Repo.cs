using System;

namespace Project24_Interface;
// bu classı ileride oluşturacağım Product, customer, category gibi farklı yapılar için mires vermek üzere oluşturuyorum.

public abstract class Repo
{
   public abstract void Create();
    public abstract void GetAll();
    public abstract void GetById();
    public abstract void Update();
    public abstract void Delete();

    public abstract void GetByUrl();


}

public class ProductRepo : Repo
{
    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void GetById()
    {
        throw new NotImplementedException();
    }

    public override void GetByUrl()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}

public class Category : Repo
{
    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void GetById()
    {
        throw new NotImplementedException();
    }

    public override void GetByUrl()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}

public class Empployee : Repo
{
    public override void Create()
    {
        throw new NotImplementedException();
    }

    public override void Delete()
    {
        throw new NotImplementedException();
    }

    public override void GetAll()
    {
        throw new NotImplementedException();
    }

    public override void GetById()
    {
        throw new NotImplementedException();
    }

    public override void GetByUrl()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}

