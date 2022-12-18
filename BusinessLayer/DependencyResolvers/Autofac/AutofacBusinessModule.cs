using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>().SingleInstance();

            builder.RegisterType<About2Manager>().As<IAbout2Service>().SingleInstance();
            builder.RegisterType<EfAbout2Dal>().As<IAbout2Dal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

            builder.RegisterType<DestinationManager>().As<IDestinationService>().SingleInstance();
            builder.RegisterType<EfDestinationDal>().As<IDestinationDal>().SingleInstance();

            builder.RegisterType<FeatureManager>().As<IFeatureService>().SingleInstance();
            builder.RegisterType<EfFeatureDal>().As<IFeatureDal>().SingleInstance();

            builder.RegisterType<Feature2Manager>().As<IFeature2Service>().SingleInstance();
            builder.RegisterType<EfFeature2Dal>().As<IFeature2Dal>().SingleInstance();

            builder.RegisterType<GuideManager>().As<IGuideService>().SingleInstance();
            builder.RegisterType<EfGuideDal>().As<IGuideDal>().SingleInstance();

            builder.RegisterType<NewsLatterManager>().As<INewsLatterService>().SingleInstance();
            builder.RegisterType<EfNewsLetterDal>().As<INewsLatterDal>().SingleInstance();

            builder.RegisterType<SubAboutManager>().As<ISubAboutService>().SingleInstance();
            builder.RegisterType<EfSubAboutDal>().As<ISubAboutDal>().SingleInstance();

            builder.RegisterType<TestimonialManager>().As<ITestimonialService>().SingleInstance();
            builder.RegisterType<EfTestimonialDal>().As<ITestimonialDal>().SingleInstance();

            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();


        }
    }
}
