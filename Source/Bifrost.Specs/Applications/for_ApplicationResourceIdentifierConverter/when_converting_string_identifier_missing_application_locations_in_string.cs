﻿using System;
using Bifrost.Applications;
using Machine.Specifications;
using It = Machine.Specifications.It;

namespace Bifrost.Specs.Applications.for_ApplicationResourceIdentifierConverter
{
    public class when_converting_string_identifier_missing_application_locations_in_string : given.an_application_resource_identifier_converter
    {
        static string string_identifier = $"{application_name}{ApplicationResourceIdentifierConverter.ApplicationSeparator}{ApplicationResourceIdentifierConverter.ApplicationResourceSeparator}Resource{ApplicationResourceIdentifierConverter.ApplicationResourceTypeSeparator}{resource_type}";
        static Exception exception;

        Because of = () => exception = Catch.Exception(() => converter.FromString(string_identifier));

        It should_throw_missing_application_locations = () => exception.ShouldBeOfExactType<MissingApplicationLocations>();
    }
}
