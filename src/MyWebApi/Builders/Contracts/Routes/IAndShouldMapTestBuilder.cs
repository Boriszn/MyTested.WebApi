﻿// MyWebApi - ASP.NET Web API Fluent Testing Framework
// Copyright (C) 2015 Ivaylo Kenov.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/.

namespace MyWebApi.Builders.Contracts.Routes
{
    /// <summary>
    /// Used for adding And() method to the route request builder.
    /// </summary>
    public interface IAndShouldMapTestBuilder : IShouldMapTestBuilder
    {
        /// <summary>
        /// And method for better readability when building route HTTP request message.
        /// </summary>
        /// <returns>The same controller builder.</returns>
        IShouldMapTestBuilder And();
    }
}
