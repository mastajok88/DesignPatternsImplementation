using DoFactoryMethod.ConcreteProducts;
using DoFactoryMethod.Creator;

namespace DoFactoryMethod.ConcreteCreator
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
