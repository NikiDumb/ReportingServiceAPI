﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingService.Application.Exceptions;

public class EntityConflictException(string message) : Exception(message)
{ }
