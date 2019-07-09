using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
//test
namespace BusinessLogic.Implementations
{
    public class FacadeImplementation : IFacadePattern
    {
        IFacadeSubSystemOne facadeSubSystemOne;
        IFacadeSubSystemTwo facadeSubSystemTwo;
        IFacadeSubSystemThree facadeSubSystemThree;
        IFacadeSubSystemFour facadeSubSystemFour;

        public FacadeImplementation(IFacadeSubSystemOne facadeSubSystemOne,
        IFacadeSubSystemTwo facadeSubSystemTwo,
        IFacadeSubSystemThree facadeSubSystemThree,
        IFacadeSubSystemFour facadeSubSystemFour)
        {
            this.facadeSubSystemOne = facadeSubSystemOne;
            this.facadeSubSystemTwo = facadeSubSystemTwo;
            this.facadeSubSystemThree = facadeSubSystemThree;
            this.facadeSubSystemFour = facadeSubSystemFour;
        }
        public void Method1()
        {
            facadeSubSystemOne.MethodOne();
            facadeSubSystemTwo.MethodTwo();
            facadeSubSystemFour.MethodFour();
        }

        public void Method2()
        {
            facadeSubSystemOne.MethodOne();
            facadeSubSystemTwo.MethodTwo();
            facadeSubSystemThree.MethodThree();
        }
    }
}
