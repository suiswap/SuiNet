﻿using Naami.SuiNet.Types;

namespace Naami.SuiNet.Apis.Event.Filter;

public record MoveEventEventFilter(SuiObjectType MoveEvent) : IEventFilter;