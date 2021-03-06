/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Httpdns.Model.V20160201
{
	public class GetResolveCountSummaryResponse : AcsResponse
	{

		private string requestId;

		private GetResolveCountSummary_ResolveSummary resolveSummary;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetResolveCountSummary_ResolveSummary ResolveSummary
		{
			get
			{
				return resolveSummary;
			}
			set	
			{
				resolveSummary = value;
			}
		}

		public class GetResolveCountSummary_ResolveSummary
		{

			private long? http;

			private long? https;

			private long? http6;

			private long? https6;

			public long? Http
			{
				get
				{
					return http;
				}
				set	
				{
					http = value;
				}
			}

			public long? Https
			{
				get
				{
					return https;
				}
				set	
				{
					https = value;
				}
			}

			public long? Http6
			{
				get
				{
					return http6;
				}
				set	
				{
					http6 = value;
				}
			}

			public long? Https6
			{
				get
				{
					return https6;
				}
				set	
				{
					https6 = value;
				}
			}
		}
	}
}
