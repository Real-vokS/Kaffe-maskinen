namespace Kaffe_maskinen
{
    internal interface ILiquidContainer
    {

        void FillContainer(int cups);

        void UseContent(int cups);

        void EmptyContainer();

        int CurrentContentInMl { get; }

    }
}