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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeSlowLogTrendResponseUnmarshaller
    {
        public static DescribeSlowLogTrendResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSlowLogTrendResponse describeSlowLogTrendResponse = new DescribeSlowLogTrendResponse();

			describeSlowLogTrendResponse.HttpResponse = context.HttpResponse;
			describeSlowLogTrendResponse.RequestId = context.StringValue("DescribeSlowLogTrend.RequestId");
			describeSlowLogTrendResponse.DBClusterId = context.StringValue("DescribeSlowLogTrend.DBClusterId");
			describeSlowLogTrendResponse.StartTime = context.StringValue("DescribeSlowLogTrend.StartTime");
			describeSlowLogTrendResponse.EndTime = context.StringValue("DescribeSlowLogTrend.EndTime");

			List<DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem> describeSlowLogTrendResponse_items = new List<DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem>();
			for (int i = 0; i < context.Length("DescribeSlowLogTrend.Items.Length"); i++) {
				DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem slowLogTrendItem = new DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem();
				slowLogTrendItem.Key = context.StringValue("DescribeSlowLogTrend.Items["+ i +"].Key");
				slowLogTrendItem.Unit = context.StringValue("DescribeSlowLogTrend.Items["+ i +"].Unit");

				List<DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem.DescribeSlowLogTrend_SeriesItem> slowLogTrendItem_series = new List<DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem.DescribeSlowLogTrend_SeriesItem>();
				for (int j = 0; j < context.Length("DescribeSlowLogTrend.Items["+ i +"].Series.Length"); j++) {
					DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem.DescribeSlowLogTrend_SeriesItem seriesItem = new DescribeSlowLogTrendResponse.DescribeSlowLogTrend_SlowLogTrendItem.DescribeSlowLogTrend_SeriesItem();
					seriesItem.Name = context.StringValue("DescribeSlowLogTrend.Items["+ i +"].Series["+ j +"].Name");
					seriesItem.Values = context.StringValue("DescribeSlowLogTrend.Items["+ i +"].Series["+ j +"].Values");

					slowLogTrendItem_series.Add(seriesItem);
				}
				slowLogTrendItem.Series = slowLogTrendItem_series;

				describeSlowLogTrendResponse_items.Add(slowLogTrendItem);
			}
			describeSlowLogTrendResponse.Items = describeSlowLogTrendResponse_items;
        
			return describeSlowLogTrendResponse;
        }
    }
}
