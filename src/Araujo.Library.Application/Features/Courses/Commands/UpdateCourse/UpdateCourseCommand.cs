﻿using MediatR;
using System;

namespace Araujo.Library.Application.Features.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
